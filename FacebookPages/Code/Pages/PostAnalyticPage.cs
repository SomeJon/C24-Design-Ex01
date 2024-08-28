using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FacebookPages.Code.Pages
{
    public partial class PostAnalyticPage : BasePage
    {
        public PostAnalyticData PageData {  get; set; }

        public PostAnalyticPage()
        {
            InitializeComponent();
        }

        private void DisplayEngagementMetrics()
        {
            int totalLikes = PageData.TotalLikes;
            int totalComments = PageData.TotalComments;
            double averageEngagementRate = PageData.AverageEngagementRate;

            // Display totals in labels
            m_TotalLikesLabel.Text = $"Total Likes: {totalLikes}";
            m_TotalCommentsLabel.Text = $"Total Comments: {totalComments}";
            m_EngagementRateLabel.Text = $"Average Engagement Rate: {averageEngagementRate}";
        }
    }
}
