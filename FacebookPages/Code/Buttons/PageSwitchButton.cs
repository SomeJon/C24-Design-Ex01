using FacebookPages.Code.Buttons;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class PageSwitchButton : Button, IHasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
    }
}
