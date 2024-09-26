using System.Windows.Forms;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoListBox : ListBox, IHasDataInfo
    {
        private object m_RecievedInfo = null;
        public eInfoChoice InfoChoice { get; set; }
        public object RecivedInfo 
        {
            get 
            {
                m_RecievedInfo = this.SelectedItem;
                return m_RecievedInfo;
            }
            
            set 
            {
                m_RecievedInfo = value;
            }
        }
    }
}
