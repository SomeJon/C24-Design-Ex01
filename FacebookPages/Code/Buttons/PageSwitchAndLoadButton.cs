using FacebookPages.Buttons;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchAndLoadButton : PageSwitchButton, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object RecivedInfo { get; set; }
    }
}
