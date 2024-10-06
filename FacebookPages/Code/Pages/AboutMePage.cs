﻿using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public partial class AboutMePage : Page
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
            FetchThread = new Thread(new ThreadStart(fetchDataInBackground));

            FetchThread.Start();
        }

        private void fetchDataInBackground()
        {
            PageData.TryFetchAndLoadPageData();

            this.Invoke((MethodInvoker)updatePageWithData);
        }

        private void updatePageWithData()
        {
            if (PageData != null)
            {
                m_FillBirthDayLabel.Text = PageData.Birthday;
                m_FillCityLabel.Text = PageData.Location?.Location.City;
                m_FillCountryLabel.Text = PageData.Location?.Location.Country;
                m_FillEmailLabel.Text = PageData.Email;
                m_FillGenderLabel.Text = PageData.Gender;
                m_FillNameLabel.Text = PageData.Name;
                m_FillHometownLabel.Text = PageData.Hometown?.Name;
            }
        }
    }
}
