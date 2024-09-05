using FacebookPages.Code.Pages.Data.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Code
{
    public partial class PostView : Form
    {
        public UpdatedPostData PostData { get; private set; }

        public PostView()
        {
            InitializeComponent();
        }

        public void LoadPostData(UpdatedPostData i_PostData)
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
                    catch(System.Net.WebException i_Exception) 
                    {
                        m_PostPicture.Image = SystemIcons.Error.ToBitmap();
                    }

                }
                else
                {
                    m_PostPicture.Image = SystemIcons.Information.ToBitmap();
                }

                m_PublishedDate.Text = PostData.CreatedTime.HasValue
                    ? $"Published: {PostData.CreatedTime.Value.ToString("g")}"
                    : "Published: N/A";
                m_LastModifiedDate.Text = PostData.UpdateTime.HasValue
                    ? $"Last Modified: {PostData.UpdateTime.Value.ToString("g")}"
                    : "Last Modified: N/A";

                m_MessageBox.Text = PostData.Message ?? "No message content available.";
            }
        }


        private void m_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
