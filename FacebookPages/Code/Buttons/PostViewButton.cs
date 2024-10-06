using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Windows.Forms;
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
        public LoadInfoListBox LoadInfoListBox 
        {
            get => m_PostsList;
            private set => m_PostsList = value;
        }

        public PostViewButton()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            m_NumOfPostsInfo.Text = "Showing - " + m_PostsList.Items.Count + " posts";
            base.Refresh();
        }

        private void m_PostsList_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if (m_PostsList.SelectedValue is EnhancedPost post)
            {
                if (!string.IsNullOrEmpty(post.ImageUrl))
                {
                    m_PostImage.LoadAsync(post.ImageUrl);
                }
                else
                {
                    m_PostImage.Image = null;
                }

                m_FillComments.Text = post.NumOfComments.ToString();
                m_FillReactions.Text = post.NumOfLikes.ToString();
                m_FillName.Text = post.From?.ToString();
            }
        }

        private void m_MorePostsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            MorePostsRequest?.Invoke(i_Sender, i_EventArgs);
        }

        private void m_ChangeConnectionButton_Click(object i_Sender, EventArgs i_EventArgs)
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
    }
}
