using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookPages.Pages;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages;
using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Data.Post;
using System.Collections.Generic;
using FacebookPages.Code.Buttons.Interfaces;

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


        public static class AppSettings
        {
            public static string SAppId = "867142571975316";
            public static string[] SPermissions = new string[] {
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
                                                                   "user_videos"
                                                                   };
        }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            switchToLoginPage();

            if (Properties.Settings.Default.SaveData)
            {
                m_SaveLogin = true;
                this.Width = Properties.Settings.Default.Width;
                this.Height = Properties.Settings.Default.Height;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Properties.Settings.Default.StartingPostion;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
                {
                    LoginResult = FacebookService.Connect(
                        Properties.Settings.Default.AccessToken);
                    tryFirstFetch();
                }
            }
        }

        private void login()
        {
            LoginResult = FacebookService.Login(AppSettings.SAppId,
                AppSettings.SPermissions);

            tryFirstFetch();
        }

        private void tryFirstFetch()
        {
            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedUser = LoginResult.LoggedInUser;

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

        private void loadInfoButton_ReceivedInfo(object i_Sender, EventArgs i_EventArgs)
        {
            processReceivedData(i_Sender);
        }

        private void switchPageButton_ChangePage(object i_Sender, EventArgs i_EventArgs)
        {
            pageSwitching(i_Sender);
        }

        private void processReceivedData(object i_IDataHolder)
        {
            IHasDataInfo loadInfoHolder = i_IDataHolder as IHasDataInfo;

            switch (loadInfoHolder?.InfoChoice)
            {
                case eInfoChoice.AppId:
                    AppSettings.SAppId = loadInfoHolder.ReceivedInfo.ToString();
                    break;
                case eInfoChoice.Filter:
                    filterLoadRequest(loadInfoHolder);
                    break;
                case eInfoChoice.Analytics:
                    postAnalyticsDataHandling(loadInfoHolder);
                    break;
                case eInfoChoice.Post:
                    PostView postView = new PostView();

                    postView.LoadPostData(loadInfoHolder.ReceivedInfo as UpdatedPostData);
                    postView.Show();
                    break;
                default:
                    MessageBox.Show("Unkown Error!");
                    break;
            }
        }

        private void postAnalyticsDataHandling(IHasDataInfo i_LoadInfoHolder)
        {
            PostAnalyticData postAnalyticData = new PostAnalyticData();
            PostAnalyticPage postAnalyticPage = new PostAnalyticPage();

            postAnalyticData.PostData = i_LoadInfoHolder.ReceivedInfo as List<UpdatedPostData>;
            postAnalyticPage.PageData = postAnalyticData;
            loadEvents(postAnalyticPage);
            m_ViewPanelControl.CurrentActivePage = postAnalyticPage;
        }

        private static void filterLoadRequest(IHasDataInfo i_LoadInfoHolder)
        {
            FilterForm getFilters = new FilterForm();
            PostsWithPaging<UpdatedPostData> dataToProcess =
                i_LoadInfoHolder.ReceivedInfo as PostsWithPaging<UpdatedPostData>;

            getFilters.LoadData(dataToProcess?.FilterData);
            getFilters.ShowDialog();

            if (getFilters.Confirmed)
            {
                if(dataToProcess != null)
                {
                    dataToProcess.FilterData = getFilters.GetData();
                }
            }
        }

        private void pageSwitching(object iChoiceDataHolder)
        {
            IHasSwitchPage switchPageButton = iChoiceDataHolder as IHasSwitchPage;

            switch (switchPageButton?.PageChoice)
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
                    User receivedFriend = (iChoiceDataHolder as IHasDataInfo)?.ReceivedInfo as User;

                    if (receivedFriend?.Id == LoggedUser.Id)
                    {
                        switchToHomePage();
                    }
                    else
                    {
                        m_CurrentWallPage = new WallPage();
                        switchToUserPage(receivedFriend);
                    }

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

        private void loadEvents(BasePage iPage) 
        { 
            iPage.RecivedInfo += this.loadInfoButton_ReceivedInfo;
            iPage.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
        }

        private void returnToWall()
        {
            m_ViewPanelControl.CurrentActivePage = m_CurrentWallPage;
        }

        private void switchToPhotoPage()
        {
            PhotosPage photosPage = new PhotosPage();

            loadEvents(photosPage);
            photosPage.PageData = m_PagesData.CurrentUser.Albums;
            m_ViewPanelControl.CurrentActivePage = photosPage;
        }

        private void startNewPageBuild
            (BasePage iPage, PageData iData, UserFetchData iFetcherData)
        {
            loadEvents(iPage);
            iData.LoadFetchData(m_UserFetchData);
            m_ViewPanelControl.CurrentActivePage = iPage;
        }

        private void switchToUserPage(User iUser)
        {
            m_PagesData.CurrentUser = iUser;
            m_UserFetchData = new UserFetchData(iUser.Id, LoginResult.AccessToken);
            m_PagesData.UserHomeData.LoadUserWallData(iUser);
            m_CurrentWallPage.PageData = m_PagesData.UserHomeData;

            startNewPageBuild(m_CurrentWallPage, m_PagesData.UserHomeData, m_UserFetchData);
        }

        private void switchToHomePage()
        {
            m_CurrentWallPage = new WallPage();
            m_CurrentWallPage.SetAsHomePage();
            switchToUserPage(LoggedUser);
        }

        private void switchToLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            
            loadEvents(loginPage);
            loginPage.RemeberLogin += this.loginPage_RememberLogin;

            m_ViewPanelControl.CurrentActivePage = loginPage;
        }

        private void switchToAboutPage() 
        {
            AboutMePage aboutPage = new AboutMePage();

            aboutPage.PageData = m_PagesData.AboutData;
            startNewPageBuild(aboutPage, m_PagesData.AboutData, m_UserFetchData);
        }

        private void switchToLoginSettingPage()
        {
            LoginSettingPage loginSettingPage = new LoginSettingPage();

            loadEvents(loginSettingPage);

            m_ViewPanelControl.CurrentActivePage = loginSettingPage;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Utils.CloseConfirm();

            if (!e.Cancel)
            {
                if (m_SaveLogin)
                {
                    Properties.Settings.Default.SaveData = true;
                    Properties.Settings.Default.Height = this.Height;
                    Properties.Settings.Default.Width = this.Width;
                    Properties.Settings.Default.StartingPostion = this.Location;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void loginPage_RememberLogin(object sender, EventArgs e)
        {
            m_SaveLogin = ((CheckBox)sender).Checked;
        }
    }
}
