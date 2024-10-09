using System.Windows.Forms;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoPicture : PictureBox, IHasDataInfo
    {
        private object m_ReceivedInfo;
        public eInfoChoice InfoChoice { get; set; }
        public object ReceivedInfo
        {
            get
            {
                if(m_ReceivedInfo == null)
                {
                    m_ReceivedInfo = this.Image;
                }

                return m_ReceivedInfo;
            }
            set => m_ReceivedInfo = value;
        }
    }
}
