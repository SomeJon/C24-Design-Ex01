using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;
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

namespace FacebookPages.Code.Pages
{
    public partial class PostAnalyticPage : BasePage
    {
        public PostAnalyticData PageData {  get; set; }

        public PostAnalyticPage()
        {
            InitializeComponent();
        }

        private void displayEngagementMetrics()
        {
            int totalLikes = PageData.TotalLikes;
            int totalComments = PageData.TotalComments;
            double averageEngagementRate = PageData.AverageEngagementRate;

            m_TotalLikesLabel.Text = $"Total Likes: {totalLikes}";
            m_TotalCommentsLabel.Text = $"Total Comments: {totalComments}";
            m_EngagementRateLabel.Text = $"Average Engagement Rate: {averageEngagementRate:F2}";
        }

        private void displayContentPerformance()
        {
            List<UpdatedPostData> top5Posts = PageData.Top5Posts;
            double postFrequency = PageData.PostFrequency;

            m_TopPerformingListBox.Items.Clear();
            foreach (var post in top5Posts)
            {
                m_TopPerformingListBox.Items.Add(post);
            }

            m_PostFrequencyLabel.Text = $"Post Frequency: {postFrequency:F2} posts/day";
            m_PostTimingImpactLabel.Text = 
                $"Optimal Post Timing: " +
                $"{PageData.PostTimingImpact.OrderByDescending(x => x.Value).First().Key} " +
                $"with {PageData.PostTimingImpact.OrderByDescending(x => x.Value).First().Value:F2} " +
                $"engagement";
        }

        private void displayPostFrequencyAndTiming()
        {
            double postFrequency = PageData.PostFrequency;
            var timingImpact = PageData.PostTimingImpact.OrderByDescending(x => x.Value).First();

            m_FrequencyImpactLabel.Text = $"Post Frequency: {postFrequency:F2} posts/day";
            m_OptimalPostTimingLabel.Text = $"Best Time: {timingImpact.Key} with {timingImpact.Value:F2} average engagement";
        }

        private void displayPostTypeAnalysis(PostTypeAnalysis i_Analysis)
        {
            if (i_Analysis != null)
            {
                m_TotalTypeLikes.Text = $"Total Likes: {i_Analysis.TotalLikes}";
                m_TotatlTypeCommments.Text = $"Total Comments: {i_Analysis.TotalComments}";
                m_AverageTypeEngagement.Text = $"Average Engagement: {i_Analysis.AverageEngagement:F2}";
            }
            else
            {
                m_TotalTypeLikes.Text = "Total Likes: N/A";
                m_TotatlTypeCommments.Text = "Total Comments: N/A";
                m_AverageTypeEngagement.Text = "Average Engagement: N/A";
            }
        }

        private void PostTypeAnalysisButton_Click(object sender, EventArgs e)
        {
            List<PostTypeAnalysis> options = PageData.PostTypeAnalyses;

            m_ChoseType.DataSource = options;
        }

        private void m_ChoseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox dataHolder = sender as ComboBox;

            if (dataHolder.SelectedItem != null)
            {
                displayPostTypeAnalysis(dataHolder.SelectedItem as  PostTypeAnalysis);
            }
        }

        private void m_EngagementMetricsButton_Click(object sender, EventArgs e)
        {
            displayEngagementMetrics();
        }

        private void m_PostFrequencyTimingButton_Click(object sender, EventArgs e)
        {
            displayPostFrequencyAndTiming();
        }

        private void m_ContentPerformanceButton_Click(object sender, EventArgs e)
        {
            displayContentPerformance();
        }

        private void m_TopPerformingListBox_DoubleClick(object sender, EventArgs e)
        {
            OnRecivedInfo(sender, e);
        }

        private void m_ReturnSwitchButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }
    }
}
