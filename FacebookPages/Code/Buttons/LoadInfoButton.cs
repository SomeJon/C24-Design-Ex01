using FacebookPages.Code.Buttons;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class LoadInfoButton : Button, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set;}
        public object RecivedInfo { get; set;}
    }
}
