using System.Windows.Forms;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoButton : Button, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set;}
        public object ReceivedInfo { get; set;}
    }
}
