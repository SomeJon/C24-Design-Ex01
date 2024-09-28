using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public class BasePage : UserControl
    {
        [Category(".Page Events")]
        [Description("Occurs when information is received " +
            "and needs to be proccessed.")]
        public event EventHandler ReceivedInfo;
        [Category(".Page Events")]
        [Description("Occurs when recieve a page change request.")]
        public event EventHandler ChangePage;
        protected internal Thread FetchThread { get; set; }

        protected virtual void OnReceivedInfo(object i_Sender, EventArgs i_EventArgs)
        {
            ReceivedInfo?.Invoke(i_Sender, i_EventArgs);
        }

        protected virtual void OnChangePage(object i_Sender, EventArgs i_EventArgs)
        {
            ChangePage?.Invoke(i_Sender, i_EventArgs);
        }
    }
}
