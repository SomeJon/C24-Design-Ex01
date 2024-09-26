using System.Windows.Forms;
using FacebookPages.Code.Buttons.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchButton : Button, IHasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
    }
}
