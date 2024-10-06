using FacebookPages.Code.Pages.Data;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public partial class AboutMePage : BasePage
    {
        public AboutMePageData PageData { private get; set; }

        public AboutMePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OnChangePage(i_Sender, i_EventArgs);
        }

        protected override void OnLoad(EventArgs i_EventArgs)
        {
            base.OnLoad(i_EventArgs);

            FetchThread = new Thread(fetchDataInBackground);
            FetchThread.Start();
        }

        private void fetchDataInBackground()
        {
            PageData.LoadAllCurrentData();
            this.Invoke(new Action(updatePageWithData));
        }

        private void updatePageWithData()
        {
            if (PageData != null)
            {
                PageData.LoadAllCurrentData();
                aboutMePageDataBindingSource.DataSource = PageData;
                aboutMePageDataBindingSource.ResetBindings(false);
            }
        }
    }
}
