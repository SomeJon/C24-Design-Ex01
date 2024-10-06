using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Data.UserManager
{
    public class SingleUserPagesData
    {
        private AboutMePageData m_AboutMeData;
        private WallPageData m_WallData;
        private PhotoPageData m_PhotoData;
        public EnhancedUser PageUser { get; }
        public AboutMePageData AboutMeData => m_AboutMeData ?? (m_AboutMeData = new AboutMePageData(PageUser));
        public WallPageData WallData => m_WallData ?? (m_WallData = new WallPageData(PageUser));
        public PhotoPageData PhotoData => m_PhotoData ?? (m_PhotoData = new PhotoPageData(PageUser));

        internal SingleUserPagesData(EnhancedUser i_User)
        {
            PageUser = i_User;
        }
    }
}