using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookPages.Code.Buttons.Interfaces;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;

namespace FacebookPages.Code.Pages
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

        public void SetAsHomePage()
        {
            m_ExitButton.Text = @"Logout";
            m_ExitButton.PageChoice = ePageChoice.Logout;
        }

        protected virtual void PageSwitchButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OnChangePage(i_Sender, i_EventArgs);
        }

        protected override void OnLoad(EventArgs i_EventArgs)
        {
            base.OnLoad(i_EventArgs);

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

            FetchThread = new Thread(fetchDataInBackground);

            FetchThread.Start();
        }

        private void m_ViewFriendButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            (i_Sender as IHasDataInfo).ReceivedInfo = m_ChooseFriend.ReceivedInfo;
            (i_Sender as IHasDataInfo).InfoChoice = eInfoChoice.Friend;

            PageSwitchButton_Click(i_Sender, i_EventArgs);
        }


        private void fetchDataInBackground()
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
            catch (System.InvalidOperationException iInvalidOperation) 
            {
                MessageBox.Show(iInvalidOperation.Message, @"Error");
            }

        }

        private void updatePageWithData(List<UpdatedPostData> i_Data)
        {
            m_PostViewButton.LoadInfoListBox.DataSource = i_Data;
            m_PostViewButton.Refresh();
        }

        private void m_PostViewButton_ChangeConnectionRequest(object i_Sender, EventArgs i_EventArgs)
        {
            lock(sr_PageDataLock)
            {
                m_PostViewButton.Clear();
                PageData.PostsWithPaging.SwitchConnection
                    (((string)(i_Sender as System.Windows.Forms.ComboBox)?.SelectedItem).ToLower());
                updatePageWithData(PageData.PostsWithPaging.Posts);
            }

        }

        private void m_PostViewButton_MorePostsRequest(object i_Sender, EventArgs i_EventArgs)
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

        private void m_PostViewButton_FilterRequest(object i_Sender, EventArgs i_EventArgs)
        {
            (i_Sender as IHasDataInfo).ReceivedInfo = PageData.PostsWithPaging;
            OnReceivedInfo(i_Sender, i_EventArgs);
            updatePageWithData(PageData.PostsWithPaging.Posts);
        }

        private void m_PostViewButton_LoadAllPosts(object i_Sender, EventArgs i_EventArgs)
        {
            lock (sr_PageDataLock)
            {
                try
                {
                    while (PageData.PostsWithPaging.TryToAddNextPage())
                    {
                        m_PostViewButton.Clear();
                        m_PostViewButton.LoadInfoListBox.DataSource = PageData.PostsWithPaging.Posts;
                        m_PostViewButton.Refresh();
                    }
                }
                catch (System.InvalidOperationException iInvalidOperation)
                {
                    MessageBox.Show(iInvalidOperation.Message, "Error");
                }
                updatePageWithData(PageData.PostsWithPaging.Posts);
            }
        }

        private void m_PostViewButton_PostSelected(object i_Sender, EventArgs i_EventArgs)
        {
            OnReceivedInfo(i_Sender, i_EventArgs);
        }

        private void m_PostViewButton_PostAnalyticRequest(object i_Sender, EventArgs i_EventArgs)
        {
            (i_Sender as IHasDataInfo).ReceivedInfo = PageData.PostsWithPaging.Posts;
            OnReceivedInfo(i_Sender, i_EventArgs);
        }
    }
}
