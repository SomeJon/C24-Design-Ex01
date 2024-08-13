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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; private set; }

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
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
                LoginResult = null;
            }

            //if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            //{
            //    //buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";
            //    //buttonLogin.BackColor = Color.LightGreen;
            //    //pictureBoxProfile.ImageLocation = LoginResult.LoggedInUser.PictureNormalURL;
            //    //buttonLogin.Enabled = false;
            //    //buttonLogout.Enabled = true;
            //}
        }

        //private void buttonLogout_Click(object sender, EventArgs e)
        //{
        //    FacebookService.LogoutWithUI();
        //    //buttonLogin.Text = "Login";
        //    //buttonLogin.BackColor = buttonLogout.BackColor;
        //    LoginResult = null;
        //    //buttonLogin.Enabled = true;
        //    //buttonLogout.Enabled = false;
        //}

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

            switch (switchPageButton.PageChoice)
            {
                case PageSwitchButton.ePageChoice.HomePage:
                    if (LoginResult == null)
                    {
                        login();
                    }

                    if (LoggedUser != null)
                    {
                        tabControl.SelectedIndex = 2;
                    }

                    break;
                case PageSwitchButton.ePageChoice.Login:
                    tabControl.SelectedIndex = 0;
                    break;
                case PageSwitchButton.ePageChoice.LoginSetting:
                    tabControl.SelectedIndex = 1;
                    break;
            }
        }

    }
}
