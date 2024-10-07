using FacebookPages.Code.Pages.Factory.Interfaces;
using System;

namespace FacebookPages.Code.Pages.Factory
{
    public interface IPageFactory
    {
        Page CreatePage(IHasSwitchPage i_PageChoice);
    }
}