using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            get
            {
                return m_PostsList;
            }
            private set 
            { 
                m_PostsList = value;
            } 
        }

        public void Clear()
        {
            m_NumOfPostsInfo.Text = "Waiting for posts";
            m_NumOfPostsInfo.Text = "Waiting for data";
            LoadInfoListBox.DataSource = null;
            LoadInfoListBox.Items.Clear();
            this.m_PostImage.Image = null;
            this.Refresh();
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

        private void m_PostsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedPostData post = m_PostsList.SelectedValue as UpdatedPostData;

            if (post != null)
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

        private void m_MorePostsButton_Click(object sender, EventArgs e)
        {
            MorePostsRequest?.Invoke(sender, e);
        }

        private void m_ChangeConnectionButton_Click(object sender, EventArgs e)
        {
            ChangeConnectionRequest?.Invoke(m_PostTypeChoiceComboBox, e);
        }

        private void m_FilterButton_Click(object sender, EventArgs e)
        {
            FilterRequest?.Invoke(sender, e);
        }

        private void m_LoadAllButton_Click(object sender, EventArgs e)
        {
            LoadAllPosts?.Invoke(sender, e);
        }

        private void m_PostsList_DoubleClick(object sender, EventArgs e)
        {
            PostSelected?.Invoke(sender, e);
        }

        private void loadInfoButton1_Click(object sender, EventArgs e)
        {
            PostAnalyticRequest?.Invoke(sender, e);
        }
    }
}
