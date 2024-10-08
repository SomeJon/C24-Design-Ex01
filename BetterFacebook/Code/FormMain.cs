using System.Windows.Forms;
using FacebookWrapper;
using FacebookPages.Code.Buttons;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using Page = FacebookPages.Code.Pages.Page;


namespace FacebookClient.Code
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; internal set; }
        public EnhancedUser LoggedUser { get; internal set; }
        public ViewPanel ViewPanel => m_ViewPanelControl;
        public Page CurrentActivePage
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

            if(Settings.Default.SaveData)
            {
                this.Width = Settings.Default.Width;
                this.Height = Settings.Default.Height;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Settings.Default.StartingPostion;
            }
        }

        public void LogoutActions()
        {
            FacebookService.LogoutWithUI();
            LoginResult = null;
            LoggedUser = null;
            Settings.Default.AccessToken = null;
            Settings.Default.SaveData = false;
            Settings.Default.Save();
        }

        public void CloseFormSave()
        {
            Settings.Default.SaveData = true;
            Settings.Default.Height = this.Height;
            Settings.Default.Width = this.Width;
            Settings.Default.StartingPostion = this.Location;
            Settings.Default.Save();
        }
        
    }
}
