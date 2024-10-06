using FacebookWrapper;
using System;
using System.Windows.Forms;
using FacebookPages.Code.Pages.Data.Post;
using static FacebookClient.Code.FormMain;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages;
using System.Collections.Generic;
using FacebookPages.Code.Pages.Factory;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;
using Page = FacebookPages.Code.Pages.Page;

namespace FacebookClient.Code
{
    public class Client
    {
        private readonly FormMain r_FormMain = new FormMain();
        private bool m_SaveLogin = false;
        public WallPage CurrentWallPage { get; set; }
        public IPageFactory PageFactory { get; set; } = new PageFactory();


        public Client()
        {
            r_FormMain.ViewPanel.ReceivedInfo += this.r_FormMain_ReceivedInfo;
            r_FormMain.ViewPanel.ChangePage += this.r_FormMain_ChangePage;
            r_FormMain.FormClosing += this.m_FormMain_FormClosing;
        }

        public void Run()
        {
            startLogin();

            Application.Run(r_FormMain);
        }

        private void startLogin()
        {
            if (Settings.Default.SaveData)
            {
                if (!string.IsNullOrEmpty(Settings.Default.AccessToken))
                {
                    r_FormMain.LoginResult = FacebookService.Connect(
                        Settings.Default.AccessToken);
                }
            }

            if(r_FormMain.LoginResult != null)
            {
                tryFirstFetch();
            }

            if(r_FormMain.LoggedUser == null)
            {
                CustomPageRequest loginRequest = new CustomPageRequest { PageChoice = ePageChoice.Login };
                LoginPage loginPage = (LoginPage)PageFactory.CreatePage(loginRequest);

                loginPage.LoginRequest += this.login;
                loginPage.ExitRequest += Application.Exit;
                loginPage.RememberLogin += this.loginPage_RememberLogin;

                r_FormMain.CurrentActivePage = loginPage;
            }
        }

        private void tryFirstFetch()
        {
            if (!string.IsNullOrEmpty(r_FormMain.LoginResult.AccessToken))
            {
                r_FormMain.LoggedUser = FacebookServicesEnhancements.FetchLoggedInUser(r_FormMain.LoginResult);

                if (m_SaveLogin)
                {
                    Settings.Default.AccessToken = r_FormMain.LoginResult.AccessToken;
                    Settings.Default.Save();
                }

                CustomPageRequest homePageRequest = new CustomPageRequest
                                                        {
                                                            PageChoice = ePageChoice.HomePage,
                                                            NewPageOwner = r_FormMain.LoggedUser
                                                        };

                r_FormMain.CurrentActivePage = PageFactory.CreatePage(homePageRequest);
            }
            else
            {
                MessageBox.Show(r_FormMain.LoginResult.ErrorMessage, "Login Failed");
                r_FormMain.LoginResult = null;
            }
        }

        private void r_FormMain_ReceivedInfo(object i_Sender, EventArgs i_EventArgs)
        {
            processReceivedData(i_Sender);
        }

        private void r_FormMain_ChangePage(object i_Sender, EventArgs i_EventArgs)
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

                    // postView.LoadPostData(loadInfoHolder.ReceivedInfo as UpdatedPostData);
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
            FacebookObjectCollectionWithPaging<EnhancedPost> dataToProcess =
                i_LoadInfoHolder.ReceivedInfo as FacebookObjectCollectionWithPaging<EnhancedPost>;

            // getFilters.LoadData(dataToProcess?.FilterData); //Todo: remove logic from form
            // getFilters.ShowDialog();
            //
            // if (getFilters.Confirmed)
            // {
            //     if (dataToProcess != null)
            //     {
            //         dataToProcess.FilterData = getFilters.GetData();
            //     }
            // }
        }

        private void postAnalyticsDataHandling(IHasDataInfo i_LoadInfoHolder)
        {
            // PostAnalyticData postAnalyticData = new PostAnalyticData();
            // PostAnalyticPage postAnalyticPage = new PostAnalyticPage();

            // postAnalyticData.PostData = i_LoadInfoHolder.ReceivedInfo as List<UpdatedPostData>;
            // postAnalyticPage.PageData = postAnalyticData;
            // r_FormMain.CurrentActivePage = postAnalyticPage;
        }

        private void pageSwitching(object i_ChoiceDataHolder)
        {
            Page nextPage = PageFactory.CreatePage(i_ChoiceDataHolder as IHasSwitchPage);

            if(nextPage == null)
            {
                logoutActions();

                CustomPageRequest loginRequest = new CustomPageRequest { PageChoice = ePageChoice.Login };
                
                nextPage = PageFactory.CreatePage(loginRequest);
            }

            r_FormMain.CurrentActivePage = nextPage;
        }

        private void returnToWall()
        {
            r_FormMain.CurrentActivePage = CurrentWallPage;
        }

        private void switchToPhotoPage()
        {
            PhotosPage photosPage = new PhotosPage();

            // photosPage.PageData = m_PagesData.CurrentUser.Albums;
            r_FormMain.CurrentActivePage = photosPage;
        }

        private void startNewPageBuild
            (Page i_Page, IPageData i_Data)
        {
            // UserFetchData userFetchData = new UserFetchData(m_PagesData.CurrentUser.Id, r_FormMain.LoginResult.AccessToken);

            // i_Data.LoadFetchData(userFetchData);
            r_FormMain.CurrentActivePage = i_Page;
        }

        private void switchToUserPage(User i_User)
        {
            // m_PagesData.CurrentUser = i_User;
            // m_PagesData.UserHomeData.LoadUserWallData(i_User);
            // CurrentWallPage.PageData = m_PagesData.UserHomeData;

            // startNewPageBuild(CurrentWallPage, m_PagesData.UserHomeData);
        }

        // private void switchToHomePage()
        // {
        //     CurrentWallPage = new WallPage();
        //     CurrentWallPage.SetAsHomePage();
        //     switchToUserPage(r_FormMain.LoggedUser);
        // }

        private void switchToLoginPage()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.RememberLogin += this.loginPage_RememberLogin;

            r_FormMain.CurrentActivePage = loginPage;
        }

        

        private void switchToLoginSettingPage()
        {
            LoginSettingPage loginSettingPage = new LoginSettingPage();

            r_FormMain.CurrentActivePage = loginSettingPage;
        }


        private void logoutActions()
        {
            switchToLoginPage();
            r_FormMain.LogoutActions();
            m_SaveLogin = false;
        }



        private void m_FormMain_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs) //todo
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

        

        private void loginPage_RememberLogin(object i_Sender, EventArgs i_EventArgs)
        {
            m_SaveLogin = ((CheckBox)i_Sender).Checked;
        }
    }
}