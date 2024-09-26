using System.Windows.Forms;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoPicture : PictureBox, IHasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object RecivedInfo { get; set; }
    }
}
