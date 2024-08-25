using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClient.Code
{
    public class PageDataManager
    {
        public AboutMePageData AboutData { get; } = new AboutMePageData();
        public WallPageData UserHomeData { get; } = new WallPageData();
        public FriendsPageData FriendsData { get; } = new FriendsPageData();
        public User CurrentUser { get; set; }
    }
}
