using FacebookPages.Pages;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Builder
{
    public interface PageBuilder
    {
        PageBuilder AddData(PageData i_PageData);
        PageBuilder AddTheme(Theme i_Theme);
        BasePage Build();
    }
}
