using FacebookClient.Pages;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Builder
{
    public class AboutMePageBuilder : PageBuilder
    {
        internal AboutMePage AboutMePageConstruct { get; } 
            = new AboutMePage();

        public PageBuilder AddData(PageData i_PageData)
        {
            AboutMePageConstruct.Data = i_PageData as AboutMePageData;
            return this;
        }

        public PageBuilder AddTheme(Theme i_Theme)
        {
            AboutMePageConstruct.PageTheme = i_Theme;
            return this;
        }

        public BasePage Build()
        {
            return AboutMePageConstruct;
        }

    }
}
