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

namespace FacebookPages.Code.Buttons
{
    public partial class PostViewButton : UserControl
    {
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

        public PostViewButton()
        {
            InitializeComponent();
        }

        private void m_PostsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedPostData post = m_PostsList.SelectedValue as UpdatedPostData;

            if (post != null)
            {
                if (post.ImageUrl != null)
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
    }
}
