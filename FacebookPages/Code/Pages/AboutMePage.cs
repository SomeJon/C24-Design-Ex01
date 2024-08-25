using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public partial class AboutMePage : BasePage
    {
        public AboutMePageData Data { private get; set; }

        public AboutMePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void AboutMePage_Load(object sender, EventArgs e)
        {
            if (Data != null)
            {
                m_FillBirthDayLabel.Text = Data.Birthday;
                m_FillCityLabel.Text = Data.Location?.Location.City;
                m_FillCountryLabel.Text = Data.Location.Location.Country;
                m_FillEmailLabel.Text = Data.Email;
                m_FillGenderLabel.Text = Data.Gender;
                m_FillNameLabel.Text = Data.Name;
                m_FillHometownLabel.Text = Data.Hometown?.Name;
            }
        }
    }
}
