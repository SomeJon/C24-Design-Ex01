using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClient.Code
{
    internal class PageDataManager
    {
        public AboutMePageData About { get; } = new AboutMePageData();
        public HomePageData Home { get; } = new HomePageData(); 
        public Theme Theme { get; }
    }
}
