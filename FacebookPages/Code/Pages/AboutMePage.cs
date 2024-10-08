using FacebookPages.Code.Pages.Data;
using System;
using System.Threading;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Pages
{
    public partial class AboutMePage : Page
    {
        internal AboutMePageData PageData { private get; set; }

        internal AboutMePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;

            OnChangePage(i_Sender, i_EventArgs);
        }

        protected override void OnLoad(EventArgs i_EventArgs)
        {
            base.OnLoad(i_EventArgs);

            new Thread(fetchDataInBackground).Start();
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
