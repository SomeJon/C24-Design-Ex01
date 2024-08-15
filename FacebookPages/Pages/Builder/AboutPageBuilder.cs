using FacebookClient.Pages;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Builder
{
    public class AboutPageBuilder : PageBuilder
    {
        internal AboutMePage AboutMePageConstruct { get; } 
            = new AboutMePage();

        public PageBuilder AddData(PageData i_PageData)
        {
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
