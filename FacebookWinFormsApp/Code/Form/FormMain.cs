using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookPages.Buttons;
using FacebookPages.Pages;
using FacebookPages.Code.Pages.Data;

namespace FacebookClient.Code
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; private set; }
        private PageDataManager m_PagesData = new PageDataManager();
        private UserFetchData m_UserFetchData;
        private bool m_SaveLogin = false;


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;


            if(!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                LoginResult = FacebookService.Connect(
                    Properties.Settings.Default.AccessToken);
                tryFirstFetch();
            }
        }

        private void login()
        {
            LoginResult = FacebookService.Login(AppSettings.s_AppID,
                AppSettings.s_Permissions);

            tryFirstFetch();
        }

        private void tryFirstFetch()
        {
            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedUser = LoginResult.LoggedInUser;
                m_UserFetchData = new UserFetchData(LoggedUser.Id, LoginResult.AccessToken);
                if(m_SaveLogin)
                {
                    Properties.Settings.Default.AccessToken = LoginResult.AccessToken;
                    Properties.Settings.Default.Save();
                }

                switchToHomePage();
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
                    else
                    {
                        switchToHomePage();
                    }

                    break;
                case PageSwitchButton.ePageChoice.Login:
                    tabControl.SelectedIndex = 0;
                    break;
                case PageSwitchButton.ePageChoice.LoginSetting:
                    tabControl.SelectedIndex = 1;
                    break;
                case PageSwitchButton.ePageChoice.AboutMePage:
                    m_PagesData.AboutData
                        .fetchAndLoadData(m_UserFetchData);
                    aboutMePage1.Data = m_PagesData.AboutData;
                    tabControl.SelectedIndex = 3;
                    break;
                case PageSwitchButton.ePageChoice.FriendPage:
                    m_PagesData.FriendsData
                        .fetchAndLoadData(m_UserFetchData);
                    friendsPage1.Data = m_PagesData.FriendsData;
                    tabControl.SelectedIndex = 4;
                    break;
                case PageSwitchButton.ePageChoice.PicturePage:
                    tabControl.SelectedIndex = 5;
                    break;
                case PageSwitchButton.ePageChoice.Logout:
                    logoutActions();
                    break;
                case PageSwitchButton.ePageChoice.Exit:
                    Application.Exit();
                    break;
            }
        }

        private void logoutActions()
        {
            FacebookService.LogoutWithUI();
            LoginResult = null;
            LoggedUser = null;
            m_PagesData = new PageDataManager();
            tabControl.SelectedIndex = 0;
            Properties.Settings.Default.AccessToken = null;
            Properties.Settings.Default.Save();
        }

        private void switchToHomePage()
        {
            m_PagesData.HomeData.ProfilePicUrl = LoggedUser?.PictureLargeURL;
            m_PagesData.HomeData.FirstName = LoggedUser?.FirstName;
            m_PagesData.HomeData.LastName = LoggedUser?.LastName;
            m_PagesData.HomeData.fetchAndLoadData(m_UserFetchData);
            homePage1.Data = m_PagesData.HomeData;
            tabControl.SelectedIndex = 2;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !PageUtils.CloseConfirm();
        }

        private void loginPage1_RemeberLogin(object sender, EventArgs e)
        {
            m_SaveLogin = (sender as CheckBox).Checked;
        }
    }
}
