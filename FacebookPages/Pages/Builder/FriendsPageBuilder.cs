using FacebookClient.Code.Pages;
using FacebookClient.Code.Pages.Data;
using FacebookClient.Pages;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Builder
{
    public class FriendsPageBuilder : PageBuilder
    {
        internal FriendsPage FriendsPageConstruct { get; }
            = new FriendsPage();

        public PageBuilder AddData(PageData i_PageData)
        {
            //FriendsPageConstruct.Data = i_PageData as HomePageData;
            return this;
        }

        public PageBuilder AddTheme(Theme i_Theme)
        {
            FriendsPageConstruct.PageTheme = i_Theme;
            return this;
        }

        public BasePage Build()
        {
            return FriendsPageConstruct;
        }
    }
}
