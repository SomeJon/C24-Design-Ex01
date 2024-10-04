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
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FacebookWrapperEnhancements.Code.UserManagement;


namespace FacebookClient.Code
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; internal set; }
        public User LoggedUser { get; internal set; }

        public ViewPanel ViewPanel => m_ViewPanelControl;
        public BasePage CurrentActivePage
        {
            get => ViewPanel.CurrentActivePage;
            set => ViewPanel.CurrentActivePage = value;
        }

        public static class AppSettings
        {
            public static string m_SAppId = "867142571975316";
            public static string[] m_SPermissions = new string[] {
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

            if (Properties.Settings.Default.SaveData)
            {
                this.Width = Properties.Settings.Default.Width;
                this.Height = Properties.Settings.Default.Height;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Properties.Settings.Default.StartingPostion;
            }
        }

        public void LogoutActions()
        {
            FacebookService.LogoutWithUI();
            LoginResult = null;
            LoggedUser = null;
            Properties.Settings.Default.AccessToken = null;
            Properties.Settings.Default.Save();
        }

        public void CloseFormSave()
        {
            Properties.Settings.Default.SaveData = true;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.StartingPostion = this.Location;
            Properties.Settings.Default.Save();
        }
        
    }
}
