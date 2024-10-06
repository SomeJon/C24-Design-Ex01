using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public partial class PostAnalyticPage : Page
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

            m_TotalLikesLabel.Text = $@"Total Likes: {totalLikes}";
            m_TotalCommentsLabel.Text = $@"Total Comments: {totalComments}";
            m_EngagementRateLabel.Text = $@"Average Engagement Rate: {averageEngagementRate:F2}";
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

            m_PostFrequencyLabel.Text = $@"Post Frequency: {postFrequency:F2} posts/day";
            m_PostTimingImpactLabel.Text = 
                $@"Optimal Post Timing: " +
                $"{PageData.PostTimingImpact.OrderByDescending(i_X => i_X.Value).First().Key} " +
                $"with {PageData.PostTimingImpact.OrderByDescending(i_X => i_X.Value).First().Value:F2} " +
                $@"engagement";
        }

        private void displayPostFrequencyAndTiming()
        {
            double postFrequency = PageData.PostFrequency;
            var timingImpact = PageData.PostTimingImpact.OrderByDescending(i_X => i_X.Value).First();

            m_FrequencyImpactLabel.Text = $@"Post Frequency: {postFrequency:F2} posts/day";
            m_OptimalPostTimingLabel.Text = $@"Best Time: {timingImpact.Key} with {timingImpact.Value:F2} average engagement";
        }

        private void displayPostTypeAnalysis(PostTypeAnalysis i_Analysis)
        {
            if (i_Analysis != null)
            {
                m_TotalTypeLikes.Text = $@"Total Likes: {i_Analysis.TotalLikes}";
                m_TotatlTypeCommments.Text = $@"Total Comments: {i_Analysis.TotalComments}";
                m_AverageTypeEngagement.Text = $@"Average Engagement: {i_Analysis.AverageEngagement:F2}";
            }
            else
            {
                m_TotalTypeLikes.Text = @"Total Likes: N/A";
                m_TotatlTypeCommments.Text = @"Total Comments: N/A";
                m_AverageTypeEngagement.Text = @"Average Engagement: N/A";
            }
        }

        private void PostTypeAnalysisButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            List<PostTypeAnalysis> options = PageData.PostTypeAnalyses;

            m_ChoseType.DataSource = options;
        }

        private void m_ChoseType_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            ComboBox dataHolder = i_Sender as ComboBox;

            if (dataHolder.SelectedItem != null)
            {
                displayPostTypeAnalysis(dataHolder.SelectedItem as  PostTypeAnalysis);
            }
        }

        private void m_EngagementMetricsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            displayEngagementMetrics();
        }

        private void m_PostFrequencyTimingButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            displayPostFrequencyAndTiming();
        }

        private void m_ContentPerformanceButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            displayContentPerformance();
        }

        private void m_TopPerformingListBox_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            OnReceivedInfo(i_Sender, i_EventArgs);
        }

        private void m_ReturnSwitchButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OnChangePage(i_Sender, i_EventArgs);
        }
    }
}
