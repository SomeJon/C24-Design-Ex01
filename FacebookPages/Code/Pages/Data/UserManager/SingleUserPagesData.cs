using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Data.UserManager
{
    public class SingleUserPagesData
    {
        public EnhancedUser PageUser { get; }
        public AboutMePageData AboutMeData { get; }
        public WallPageData WallData { get; }
        // public PostAnalyticData PostAnalyticData { get; }

        internal SingleUserPagesData(EnhancedUser i_User)
        {
            PageUser = i_User;
            AboutMeData = new AboutMePageData(i_User);
            WallData = new WallPageData(i_User);
        }
    }
}