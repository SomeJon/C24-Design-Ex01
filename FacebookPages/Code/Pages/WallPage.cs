using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FacebookPages.Pages
{
    public partial class WallPage : BasePage
    {
        public override Color BackColor { get; set; }
        public WallPageData PageData { get; set; }
        public static readonly object sr_PageDataLock = new object();

        public WallPage()
        {
            InitializeComponent();
        }

        protected virtual void PageSwitchButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (PageData?.ProfilePicUrl != null)
            {
                profilePicture.LoadAsync(PageData.ProfilePicUrl);
            }

            if (PageData?.CoverPicUrl != null)
            {
                coverPicture.LoadAsync(PageData.CoverPicUrl);
                coverPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            m_ChooseFriend.DataSource = PageData?.Friends;
            m_FillNumberOfFriends.Text = PageData?.Friends.Count.ToString();
            textBoxFullName.Text = PageData?.FirstName
                + " " + PageData?.LastName;

            FetchThread = new Thread(new ThreadStart(FetchDataInBackground));

            FetchThread.Start();
        }

        private void m_ViewFriendButton_Click(object sender, EventArgs e)
        {
            (sender as HasDataInfo).RecivedInfo = m_ChooseFriend.RecivedInfo;
            (sender as HasDataInfo).InfoChoice = eInfoChoice.Friend;

            PageSwitchButton_Click(sender, e);
        }


        private void FetchDataInBackground()
        {
            lock (sr_PageDataLock)
            {
                PageData.TryFetchAndLoadPageData();
            }

            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    updatePageWithData(PageData.PostsWithPaging.Posts);
                });
            } 
            catch (System.InvalidOperationException i_InvalidOperation) 
            {
                MessageBox.Show(i_InvalidOperation.Message, "Error");
            }

        }

        private void updatePageWithData(List<UpdatedPostData> data)
        {
            m_PostViewButton.LoadInfoListBox.DataSource = data;
            m_PostViewButton.Refresh();
        }

        private void m_PostViewButton_ChangeConnectionRequest(object sender, EventArgs e)
        {
            lock(sr_PageDataLock)
            {
                m_PostViewButton.Clear();
                PageData.PostsWithPaging.SwitchConnection
                    (((sender as System.Windows.Forms.ComboBox).SelectedItem as string).ToLower());
                updatePageWithData(PageData.PostsWithPaging.Posts);
            }

        }

        private void m_PostViewButton_MorePostsRequest(object sender, EventArgs e)
        {
            lock (sr_PageDataLock)
            {
                m_PostViewButton.Clear();
                if (!PageData.PostsWithPaging.TryToAddNextPage())
                {
                    MessageBox.Show("No more Posts were found", "Posts request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                updatePageWithData(PageData.PostsWithPaging.Posts);
            }
        }

        private void m_PostViewButton_FilterRequest(object sender, EventArgs e)
        {
            (sender as HasDataInfo).RecivedInfo = PageData.PostsWithPaging;
            OnRecivedInfo(sender, e);
            updatePageWithData(PageData.PostsWithPaging.Posts);
        }

        private void m_PostViewButton_LoadAllPosts(object sender, EventArgs e)
        {
            lock (sr_PageDataLock)
            {
                try
                {
                    while (PageData.PostsWithPaging.TryToAddNextPage())
                    {
                        m_PostViewButton.Refresh();
                    }
                }
                catch (System.InvalidOperationException i_InvalidOperation)
                {
                    MessageBox.Show(i_InvalidOperation.Message, "Error");
                }
                updatePageWithData(PageData.PostsWithPaging.Posts);
            }
        }

        private void m_PostViewButton_PostSelected(object sender, EventArgs e)
        {
            OnRecivedInfo(sender, e);
        }
    }
}
