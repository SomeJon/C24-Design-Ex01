using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchAndLoadButton : PageSwitchButton, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object ReceivedInfo { get; set; }
    }
}
