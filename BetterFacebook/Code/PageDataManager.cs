using FacebookPages.Code.Pages.Data;
using FacebookWrapper.ObjectModel;

namespace FacebookClient.Code
{
    public class PageDataManager
    {
        public AboutMePageData AboutData { get; }// = new AboutMePageData();
        public WallPageData UserHomeData { get; }// = new WallPageData();
        public User CurrentUser { get; set; }
    }
}
