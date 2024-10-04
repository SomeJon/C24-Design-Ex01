using FacebookWrapper;
using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookPages.Code.Buttons.Interfaces;
using FacebookPages.Code.Pages.Data.Post;
using static FacebookClient.Code.FormMain;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookClient.Code
{
    public class Client
    {
        private readonly FormMain r_FormMain = new FormMain();
        public WallPage CurrentWallPage { get; set; }
        private bool m_SaveLogin = false;
        private PageDataManager m_PagesData = new PageDataManager();

        public Client()
        {
            r_FormMain.ViewPanel.ReceivedInfo += this.m_FormMain_ReceivedInfo;
            r_FormMain.ViewPanel.ChangePage += this.m_FormMain_ChangePage;
            r_FormMain.FormClosing += this.m_FormMain_FormClosing;
        }

        public void Run()
        {
            switchToLoginPage();

            if (Properties.Settings.Default.SaveData)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
                {
                    r_FormMain.LoginResult = FacebookService.Connect(
                        Properties.Settings.Default.AccessToken);
                    tryFirstFetch();

                    EnhancedUser ProxiedUser = FacebookServicesEnhancements.FetchLoggedInUser(r_FormMain.LoginResult);

                    FacebookObjectCollection<EnhancedPost> newPosts = ProxiedUser.Posts;

                }
            }

            Application.Run(r_FormMain);
        }

        private void m_FormMain_ReceivedInfo(object i_Sender, EventArgs i_EventArgs)
        {
            processReceivedData(i_Sender);
        }

        private void m_FormMain_ChangePage(object i_Sender, EventArgs i_EventArgs)
        {
            pageSwitching(i_Sender);
        }

        private void processReceivedData(object i_DataHolder)
        {
            IHasDataInfo loadInfoHolder = i_DataHolder as IHasDataInfo;

            switch (loadInfoHolder?.InfoChoice)
            {
                case eInfoChoice.AppId:
                    AppSettings.m_SAppId = loadInfoHolder.ReceivedInfo.ToString();
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

        private static void filterLoadRequest(IHasDataInfo i_LoadInfoHolder)
        {
            FilterForm getFilters = new FilterForm();
            PostsWithPaging<UpdatedPostData> dataToProcess =
                i_LoadInfoHolder.ReceivedInfo as PostsWithPaging<UpdatedPostData>;

            getFilters.LoadData(dataToProcess?.FilterData); //Todo: remove logic from form
            getFilters.ShowDialog();

            if (getFilters.Confirmed)
            {
                if (dataToProcess != null)
                {
                    dataToProcess.FilterData = getFilters.GetData();
                }
            }
        }

        private void postAnalyticsDataHandling(IHasDataInfo i_LoadInfoHolder)
        {
            PostAnalyticData postAnalyticData = new PostAnalyticData();
            PostAnalyticPage postAnalyticPage = new PostAnalyticPage();

            postAnalyticData.PostData = i_LoadInfoHolder.ReceivedInfo as List<UpdatedPostData>;
            postAnalyticPage.PageData = postAnalyticData;
            r_FormMain.CurrentActivePage = postAnalyticPage;
        }

        private void pageSwitching(object i_ChoiceDataHolder)
        {
            IHasSwitchPage switchPageButton = i_ChoiceDataHolder as IHasSwitchPage;

            switch (switchPageButton?.PageChoice)
            {
                case ePageChoice.HomePage:
                    if (r_FormMain.LoginResult == null)
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
                    User receivedFriend = (i_ChoiceDataHolder as IHasDataInfo)?.ReceivedInfo as User;

                    if (receivedFriend?.Id == r_FormMain.LoggedUser.Id)
                    {
                        switchToHomePage();
                    }
                    else
                    {
                        CurrentWallPage = new WallPage();
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

        private void returnToWall()
        {
            r_FormMain.CurrentActivePage = CurrentWallPage;
        }

        private void switchToPhotoPage()
        {
            PhotosPage photosPage = new PhotosPage();

            photosPage.PageData = m_PagesData.CurrentUser.Albums;
            r_FormMain.CurrentActivePage = photosPage;
        }

        private void startNewPageBuild
            (BasePage i_Page, PageData i_Data)
        {
            UserFetchData userFetchData = new UserFetchData(m_PagesData.CurrentUser.Id, r_FormMain.LoginResult.AccessToken);

            i_Data.LoadFetchData(userFetchData);
            r_FormMain.CurrentActivePage = i_Page;
        }

        private void switchToUserPage(User i_User)
        {
            m_PagesData.CurrentUser = i_User;
            m_PagesData.UserHomeData.LoadUserWallData(i_User);
            CurrentWallPage.PageData = m_PagesData.UserHomeData;

            startNewPageBuild(CurrentWallPage, m_PagesData.UserHomeData);
        }

        private void switchToHomePage()
        {
            CurrentWallPage = new WallPage();
            CurrentWallPage.SetAsHomePage();
            switchToUserPage(r_FormMain.LoggedUser);
        }

        private void switchToLoginPage()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.RemeberLogin += this.loginPage_RememberLogin;

            r_FormMain.CurrentActivePage = loginPage;
        }

        private void switchToAboutPage()
        {
            AboutMePage aboutPage = new AboutMePage();

            aboutPage.PageData = m_PagesData.AboutData;
            startNewPageBuild(aboutPage, m_PagesData.AboutData);
        }

        private void switchToLoginSettingPage()
        {
            LoginSettingPage loginSettingPage = new LoginSettingPage();

            r_FormMain.CurrentActivePage = loginSettingPage;
        }


        private void logoutActions()
        {
            switchToLoginPage();
            m_PagesData = new PageDataManager();
            r_FormMain.LogoutActions();
        }



        private void m_FormMain_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            i_EventArgs.Cancel = !Utils.CloseConfirm();

            if (!i_EventArgs.Cancel)
            {
                if(m_SaveLogin)
                {
                    r_FormMain.CloseFormSave();
                }
            }
        }

        private void login()
        {
            r_FormMain.LoginResult = FacebookService.Login(AppSettings.m_SAppId,
                AppSettings.m_SPermissions);

            tryFirstFetch();
        }

        private void tryFirstFetch()
        {
            if (!string.IsNullOrEmpty(r_FormMain.LoginResult.AccessToken))
            {
                r_FormMain.LoggedUser = r_FormMain.LoginResult.LoggedInUser;
                m_PagesData.CurrentUser = r_FormMain.LoggedUser;

                if (m_SaveLogin)
                {
                    Properties.Settings.Default.AccessToken = r_FormMain.LoginResult.AccessToken;
                    Properties.Settings.Default.Save();
                }

                switchToHomePage();
            }
            else
            {
                MessageBox.Show(r_FormMain.LoginResult.ErrorMessage, "Login Failed");
                r_FormMain.LoginResult = null;
            }
        }

        private void loginPage_RememberLogin(object i_Sender, EventArgs i_EventArgs)
        {
            m_SaveLogin = ((CheckBox)i_Sender).Checked;
        }
    }
}