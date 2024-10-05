using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookClient.Code
{
    public partial class PostView : Form
    {
        public EnhancedPost PostData { get; private set; }

        public PostView()
        {
            InitializeComponent();
        }

        public void LoadPostData(EnhancedPost i_PostData)
        {
            if (i_PostData == null)
            {
                MessageBox.Show("No post data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PostData = i_PostData;

                m_LikesLabel.Text = $"Likes: {PostData.NumOfLikes}";
                m_CommeantsLable.Text = $"Comments: {PostData.NumOfComments}";

                m_PostTypeLabel.Text = $"Post Type: {PostData.Type?.ToString() ?? "N/A"}";

                m_FullNameLabel.Text = PostData.Name ?? "Unknown";
                
                if (!string.IsNullOrEmpty(PostData.From?.PictureNormalURL))
                {
                    m_PublisherSmallPicture.Load(PostData.From.PictureNormalURL);
                }
                else
                {
                    m_PublisherSmallPicture.Image = SystemIcons.Information.ToBitmap();
                }

                if (!string.IsNullOrEmpty(PostData.ImageUrl))
                {
                    try
                    {
                        m_PostPicture.Load(PostData.ImageUrl);
                    }
                    catch(System.Net.WebException iException) 
                    {
                        m_PostPicture.Image = SystemIcons.Error.ToBitmap();
                    }

                }
                else
                {
                    m_PostPicture.Image = SystemIcons.Information.ToBitmap();
                }

                m_PublishedDate.Text = PostData.CreatedTime.HasValue
                    ? $"Published: {PostData.CreatedTime.Value:g}"
                    : "Published: N/A";
                m_LastModifiedDate.Text = PostData.UpdateTime.HasValue
                    ? $"Last Modified: {PostData.UpdateTime.Value:g}"
                    : "Last Modified: N/A";

                m_MessageBox.Text = PostData.Message ?? "No message content available.";
            }
        }


        private void m_ExitButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Close();
        }
    }
}
