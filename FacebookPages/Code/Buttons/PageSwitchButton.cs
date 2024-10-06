using System.Windows.Forms;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchButton : Button, IHasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
    }
}
