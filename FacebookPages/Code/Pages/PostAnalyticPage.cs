using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Windows.Forms;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages
{
    public partial class PostAnalyticPage : Page
    {
        public PostAnalyticData PageData {  get; set; }

        public PostAnalyticPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs i_EventArgs)
        {
            base.OnLoad(i_EventArgs);

            m_ChoseType.DataSource = PageData.PostTypeAnalyses;
            new Thread(loadInBackground).Start();

        }

        private void loadInBackground()
        {
            int totalLikes = PageData.TotalLikes;
            int totalComments = PageData.TotalComments;
            double averageEngagementRate = PageData.AverageEngagementRate;
            List<EnhancedPost> top5Posts = PageData.Top5Posts;
            double postFrequency = PageData.PostFrequency;
            KeyValuePair<string, double> timingImpact = PageData.PostTimingImpact
                .OrderByDescending(i_X => i_X.Value).First();

            this.Invoke(new Action(() =>
                {
                    displayEngagementMetrics(totalLikes, totalComments, averageEngagementRate);

                    displayContentPerformance(top5Posts, postFrequency);

                    displayPostFrequencyAndTiming(postFrequency, timingImpact);
                }));
        }

        private void displayEngagementMetrics(int i_TotalLikes, int i_TotalComments, double i_AverageEngagementRate)
        {
            m_TotalLikesLabel.Text = $@"Total Likes: {i_TotalLikes}";
            m_TotalCommentsLabel.Text = $@"Total Comments: {i_TotalComments}";
            m_EngagementRateLabel.Text = $@"Average Engagement Rate: {i_AverageEngagementRate:F2}";
        }

        private void displayContentPerformance(List<EnhancedPost> i_Top5Posts, double i_PostFrequency)
        {
            m_TopPerformingListBox.Items.Clear();
            foreach (var post in i_Top5Posts)
            {
                m_TopPerformingListBox.Items.Add(post);
            }

            m_PostFrequencyLabel.Text = $@"Post Frequency: {i_PostFrequency:F2} posts/day";
            m_PostTimingImpactLabel.Text =
                $@"Optimal Post Timing: " +
                $"{PageData.PostTimingImpact.OrderByDescending(i_X => i_X.Value).First().Key} " +
                $"with {PageData.PostTimingImpact.OrderByDescending(i_X => i_X.Value).First().Value:F2} " +
                $@"engagement";
        }

        private void displayPostFrequencyAndTiming(double i_PostFrequency, KeyValuePair<string, double> i_TimingImpact)
        {
            m_FrequencyImpactLabel.Text = $@"Post Frequency: {i_PostFrequency:F2} posts/day";
            m_OptimalPostTimingLabel.Text = $@"Best Time: {i_TimingImpact.Key} with {i_TimingImpact.Value:F2} average engagement";
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

        private void m_ChoseType_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            ComboBox dataHolder = i_Sender as ComboBox;

            if (dataHolder.SelectedItem != null)
            {
                displayPostTypeAnalysis(dataHolder.SelectedItem as  PostTypeAnalysis);
            }
        }

        private void m_TopPerformingListBox_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            OnReceivedInfo(i_Sender, i_EventArgs);
        }

        private void m_ReturnSwitchButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;

            OnChangePage(i_Sender, i_EventArgs);
        }
    }
}
