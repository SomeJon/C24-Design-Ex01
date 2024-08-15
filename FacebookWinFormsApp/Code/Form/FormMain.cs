using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using FacebookClient.Pages;
using FacebookClient.Buttons;
using CefSharp.DevTools.Debugger;
using FacebookClient.Code.Pages.Data;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; private set; }
        private HomePageData m_HomePageData = new HomePageData();


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            
        }

        private void login()
        {
            LoginResult = FacebookService.Login(AppSettings.s_AppID,
                    AppSettings.s_Permissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedUser = LoginResult.LoggedInUser;

                m_HomePageData.ProfilePicUrl = LoggedUser.PictureLargeURL;
                m_HomePageData.UserName = LoggedUser.UserName;
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
                LoginResult = null;
            }
        }

        public static class AppSettings
        {
            public static string s_AppID = "867142571975316";
            public static string[] s_Permissions = new string[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            //"user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"};
        }

        private void loadInfoButton_RecievedInfo(object sender, EventArgs e)
        {
            LoadInfoButton loadInfoButton = sender as LoadInfoButton;
            
            switch (loadInfoButton.InfoChoice)
            {
                case LoadInfoButton.eInfoChoice.AppId:
                    AppSettings.s_AppID = loadInfoButton.RecivedInfo.ToString();
                    break;
                default:
                    MessageBox.Show("Big big error happened!");
                    break;

            }
        }

        private void switchPageButton_ChangePage(object sender, EventArgs e)
        {
            PageSwitchButton switchPageButton = sender as PageSwitchButton;

            //todo: add a page factory, after which the data conainer would be loaded

            switch (switchPageButton.PageChoice)
            {
                case PageSwitchButton.ePageChoice.HomePage:
                    if (LoginResult == null)
                    {
                        login();
                    }

                    if (LoggedUser != null)
                    {
                        homePage1.Data = m_HomePageData;
                        tabControl.SelectedIndex = 2;
                    }

                    break;
                case PageSwitchButton.ePageChoice.Login:
                    tabControl.SelectedIndex = 0;
                    break;
                case PageSwitchButton.ePageChoice.LoginSetting:
                    tabControl.SelectedIndex = 1;
                    break;
                case PageSwitchButton.ePageChoice.AboutMePage:
                    tabControl.SelectedIndex = 3;
                    break;
                case PageSwitchButton.ePageChoice.FriendPage:
                    tabControl.SelectedIndex = 4;
                    break;
                case PageSwitchButton.ePageChoice.PicturePage:
                    tabControl.SelectedIndex = 5;
                    break;
                case PageSwitchButton.ePageChoice.Logout:
                    FacebookService.LogoutWithUI();
                    LoginResult = null;
                    LoggedUser = null;
                    m_HomePageData = new HomePageData();
                    tabControl.SelectedIndex = 0;
                    break;
            }
        }

    }
}
