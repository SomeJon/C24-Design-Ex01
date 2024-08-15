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
    public class HomePageBuilder : PageBuilder
    {
        internal HomePage HomePageConstruct { get; }
            = new HomePage();

        public PageBuilder AddData(PageData i_PageData)
        {
            HomePageConstruct.Data = i_PageData as HomePageData;
            return this;
        }

        public PageBuilder AddTheme(Theme i_Theme)
        {
            HomePageConstruct.PageTheme = i_Theme;
            return this;
        }

        public BasePage Build()
        {
            return  HomePageConstruct;
        }
    }
}
