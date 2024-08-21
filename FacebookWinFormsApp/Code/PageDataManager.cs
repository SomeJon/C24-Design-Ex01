using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages.Data;
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
        public HomePageData HomeData { get; } = new HomePageData(); 
        public Theme ThemeData { get; }
    }
}
