using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Data.UserManager
{
    public class SingleUserPagesData
    {
        private AboutMePageData m_AboutMeData;
        private WallPageData m_WallData;
        public EnhancedUser PageUser { get; }
        public AboutMePageData AboutMeData => m_AboutMeData ?? (m_AboutMeData = new AboutMePageData(PageUser));
        public WallPageData WallData => m_WallData ?? (m_WallData = new WallPageData(PageUser));
        // public PostAnalyticData PostAnalyticData { get; }

        internal SingleUserPagesData(EnhancedUser i_User)
        {
            PageUser = i_User;
        }
    }
}