using System.Windows.Forms;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchButton : Button, IHasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
        public EnhancedUser NewPageOwner { get; set; }
    }
}
