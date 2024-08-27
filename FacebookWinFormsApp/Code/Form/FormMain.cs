using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookPages.Buttons;
using FacebookPages.Pages;
using FacebookPages.Code.Pages.Data;
using System.Linq;
using FacebookPages.Code.Pages;
using FacebookPages.Code.Buttons;

namespace FacebookClient.Code
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; private set; }
        private PageDataManager m_PagesData = new PageDataManager();
        private UserFetchData m_UserFetchData;
        private WallPage m_CurrentWallPage;
        private bool m_SaveLogin = false;


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            switchToLoginPage();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
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
                //LoggedUser = LoggedUser.Friends[0];

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
            HasDataInfo loadInfoButton = sender as HasDataInfo;
            
            switch (loadInfoButton.InfoChoice)
            {
                case eInfoChoice.AppId:
                    AppSettings.s_AppID = loadInfoButton.RecivedInfo.ToString();
                    break;
                default:
                    MessageBox.Show("Big big error happened!");
                    break;

            }
        }

        private void switchPageButton_ChangePage(object sender, EventArgs e)
        {
            HasSwitchPage switchPageButton = sender as HasSwitchPage;

            switch (switchPageButton.PageChoice)
            {
                case ePageChoice.HomePage:
                    if (LoginResult == null)
                    {
                        login();
                    }
                    else
                    {
                        switchToHomePage();
                    }

                    break;
                case ePageChoice.WallPage:
                    returnToWall();
                    break;
                case ePageChoice.Login:
                    switchToLoginPage();
                    break;
                case ePageChoice.LoginSetting:
                    switchToLoginSettingPage();
                    break;
                case ePageChoice.AboutMePage:
                    switchToAboutPage();
                    break;
                case ePageChoice.FriendPage:
                    m_CurrentWallPage = new WallPage();
                    switchToUserPage((sender as HasDataInfo).RecivedInfo as User);
                    break;
                case ePageChoice.PicturePage:
                    switchToPhotoPage();
                    break;
                case ePageChoice.Logout:
                    logoutActions();
                    break;
                case ePageChoice.Exit:
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
            switchToLoginPage();
            Properties.Settings.Default.AccessToken = null;
            Properties.Settings.Default.Save();
        }

        private void loadEvents(BasePage i_Page) 
        { 
            i_Page.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            i_Page.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
        }

        private void returnToWall()
        {
            m_ViewPanelControl.CurrentPage = m_CurrentWallPage;
        }

        private void switchToPhotoPage()
        {
            PhotosPage photosPage = new PhotosPage();
            //To comlete
            loadEvents(photosPage);

            m_ViewPanelControl.CurrentPage = photosPage;
        }

        private void switchToUserPage(User i_User)
        {
            loadEvents(m_CurrentWallPage);
            m_PagesData.CurrentUser = i_User;
            m_UserFetchData = new UserFetchData(i_User.Id, LoginResult.AccessToken);
            m_PagesData.UserHomeData.LoadUserWallData(i_User);
            m_PagesData.UserHomeData.TryFetchAndLoadData(m_UserFetchData);
            m_CurrentWallPage.Data = m_PagesData.UserHomeData;

            m_ViewPanelControl.CurrentPage = m_CurrentWallPage;
        }

        private void switchToHomePage()
        {
            m_CurrentWallPage = new HomePage();
            switchToUserPage(LoggedUser);
        }

        private void switchToLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            
            loadEvents(loginPage);
            loginPage.RemeberLogin += new System.EventHandler(this.loginPage_RemeberLogin);

            m_ViewPanelControl.CurrentPage = loginPage;
        }

        private void switchToAboutPage() 
        {
            AboutMePage aboutPage = new AboutMePage();

            loadEvents(aboutPage);
            m_PagesData.AboutData
                        .TryFetchAndLoadData(m_UserFetchData);
            aboutPage.Data = m_PagesData.AboutData;

            m_ViewPanelControl.CurrentPage = aboutPage;
        }

        private void switchToLoginSettingPage()
        {
            LoginSettingPage loginSettingPage = new LoginSettingPage();

            loadEvents(loginSettingPage);

            m_ViewPanelControl.CurrentPage = loginSettingPage;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !PageUtils.CloseConfirm();
        }

        private void loginPage_RemeberLogin(object sender, EventArgs e)
        {
            m_SaveLogin = (sender as CheckBox).Checked;
        }
    }
}
