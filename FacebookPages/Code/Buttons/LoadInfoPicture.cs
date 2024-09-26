using System.Windows.Forms;
using FacebookPages.Code.Buttons.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoPicture : PictureBox, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object ReceivedInfo { get; set; }
    }
}
