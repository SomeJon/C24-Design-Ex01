using System;
using System.Windows.Forms;
using System.ComponentModel;
using FacebookPages.Pages.Data;

namespace FacebookClient.Pages
{
    public class BasePage : UserControl
    {
        [Category(".Page Events")]
        [Description("Occurs when information is received " +
            "and needs to be proccessed.")]
        public event EventHandler RecivedInfo;
        [Category(".Page Events")]
        [Description("Occurs when recieve a page change request.")]
        public event EventHandler ChangePage;
        public Theme PageTheme { get; internal set; }

        protected void OnRecivedInfo(object sender, EventArgs e)
        {
            RecivedInfo?.Invoke(sender, e);
        }

        protected void OnChangePage(object sender, EventArgs e)
        {
            ChangePage?.Invoke(sender, e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BasePage
            // 
            this.Name = "BasePage";
            this.Size = new System.Drawing.Size(858, 500);
            this.ResumeLayout(false);

        }
    }
}
