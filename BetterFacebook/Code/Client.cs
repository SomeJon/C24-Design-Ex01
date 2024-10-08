using FacebookWrapper;
using System;
using System.Windows.Forms;
using FacebookPages.Code.Pages.Data.Post;
using static FacebookClient.Code.FormMain;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages;
using System.Collections.Generic;
using System.Diagnostics;
using FacebookPages.Code.Pages.Factory;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;
using Page = FacebookPages.Code.Pages.Page;

namespace FacebookClient.Code
{
    public class Client
    {
        private readonly FormMain r_FormMain = new FormMain();
        private bool m_SaveLogin = Settings.Default.SaveData;
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

            FilterData unsavedData = new FilterData();
            FilterData savedData = unsavedData.DeepClone();
            FilterForm newFilterForm = new FilterForm(savedData);

            newFilterForm.ShowDialog();

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
                case eInfoChoice.Post:
                    PostView postView = new PostView(loadInfoHolder.ReceivedInfo as EnhancedPost);

                    postView.Show();
                    break;
                default:
                    MessageBox.Show("Unkown Error!");
                    break;
            }
        }

        private void filterLoadRequest(IHasDataInfo i_LoadInfoHolder)
        {
            FilterData currentFilterData = i_LoadInfoHolder.ReceivedInfo as FilterData;
            Debug.Assert(currentFilterData != null, nameof(currentFilterData) + " != null");
            FilterData newFilterData = currentFilterData.DeepClone();
            FilterForm getFilters = new FilterForm(newFilterData);

            getFilters.ShowDialog();

            if (getFilters.Confirmed)
            {
                WallPage currentWallPage = r_FormMain.CurrentActivePage as WallPage;
                currentWallPage?.LoadFilterData(newFilterData);
            }
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

        private void logoutActions()
        {
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