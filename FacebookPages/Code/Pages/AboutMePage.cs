using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            FetchThread = new Thread(new ThreadStart(FetchDataInBackground));

            FetchThread.Start();
        }

        private void FetchDataInBackground()
        {
            PageData.TryFetchAndLoadPageData();

            this.Invoke((MethodInvoker)delegate {
                updatePageWithData();
            });
        }

        private void updatePageWithData()
        {
            if (PageData != null)
            {
                m_FillBirthDayLabel.Text = PageData.Birthday;
                m_FillCityLabel.Text = PageData.Location?.Location.City;
                m_FillCountryLabel.Text = PageData.Location.Location.Country;
                m_FillEmailLabel.Text = PageData.Email;
                m_FillGenderLabel.Text = PageData.Gender;
                m_FillNameLabel.Text = PageData.Name;
                m_FillHometownLabel.Text = PageData.Hometown?.Name;
            }
        }
    }
}
