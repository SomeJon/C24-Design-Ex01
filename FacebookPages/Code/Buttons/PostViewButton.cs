using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Threading;
using System.Windows.Forms;
using FacebookPages.Code.Pages.Data;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Buttons
{
    public partial class PostViewButton : UserControl
    {
        public event EventHandler MorePostsRequest;
        public event EventHandler ChangeConnectionRequest;
        public event EventHandler PostSelected;
        public event EventHandler FilterRequest;
        public event EventHandler LoadAllPosts;
        public event EventHandler PostAnalyticRequest;


        public PostViewButton()
        {
            InitializeComponent();
        }

        public void LoadDataSource(WallPageData i_DataSource)
        {
            this.wallPageDataBindingSource.DataSource = i_DataSource;
            ePostConnectionOptionsBindingSource.DataSource = Enum.GetValues(typeof(UserPostFeed.ePostConnectionOptions));
        }

        public override void Refresh()
        {
            wallPageDataBindingSource.ResetBindings(false);
            base.Refresh();
        }

        private void m_MorePostsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            MorePostsRequest?.Invoke(i_Sender, i_EventArgs);
        }

        private void m_PostTypeChoiceComboBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            ChangeConnectionRequest?.Invoke(m_PostTypeChoiceComboBox, i_EventArgs);
        }

        private void m_FilterButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            FilterRequest?.Invoke(i_Sender, i_EventArgs);
        }

        private void m_LoadAllButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            LoadAllPosts?.Invoke(i_Sender, i_EventArgs);
        }

        private void m_PostsList_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            PostSelected?.Invoke(i_Sender, i_EventArgs);
        }

        private void m_SwitchToAnalytics_Click(object i_Sender, EventArgs i_EventArgs)
        {
            PostAnalyticRequest?.Invoke(i_Sender, i_EventArgs);
        }

        private void feedListBindingSource_ListChanged(object i_Sender, System.ComponentModel.ListChangedEventArgs e)
        {
            int postCount = feedListBindingSource.Count;
            m_NumOfPostsInfo.Text = $"Showing {postCount} posts";
        }
    }
}
