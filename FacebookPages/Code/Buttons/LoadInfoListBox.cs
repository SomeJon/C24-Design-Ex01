using System.Windows.Forms;
using FacebookPages.Code.Buttons.Interfaces;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoListBox : ListBox, IHasDataInfo
    {
        private object m_ReceivedInfo = null;
        public eInfoChoice InfoChoice { get; set; }
        public object ReceivedInfo 
        {
            get 
            {
                m_ReceivedInfo = this.SelectedItem;
                return m_ReceivedInfo;
            }
            
            set => m_ReceivedInfo = value;
        }
    }
}
