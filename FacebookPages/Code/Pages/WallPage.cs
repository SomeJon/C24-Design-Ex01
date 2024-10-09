using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using static FacebookPages.Code.Pages.Data.UserPostFeed;

namespace FacebookPages.Code.Pages
{
    public partial class WallPage : Page
    {
        public override Color BackColor { get; set; }
        internal WallPageData PageData { private get; set; }
        private static readonly object sr_PostDataLock = new object();

        internal WallPage()
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
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;

            OnChangePage(i_Sender, i_EventArgs);
        }

        protected override void OnLoad(EventArgs i_EventArgs)
        {
            base.OnLoad(i_EventArgs);

            new Thread(fetchPostsDataInBackgroundSet).Start();
            new Thread(fetchNonPostsDataInBackground).Start();

            
        }

        private void fetchNonPostsDataInBackground()
        {
            try
            {
                PageData.FetchNonPostsData();

                this.Invoke(
                    (MethodInvoker)updatePageWithNonPostData);
            }
            catch (InvalidOperationException invalidOperation)
            {
                MessageBox.Show(invalidOperation.Message, @"Error");
            }
        }

        private void fetchPostsDataInBackgroundSet()
        {
            lock (sr_PostDataLock)
            {
                try
                {
                    List<EnhancedPost> postDataToLoad = PageData.FeedPaged.CollectionData;

                    this.Invoke(new Action((() => m_PostViewButton.LoadDataSource(PageData))));
                    this.Invoke((MethodInvoker)delegate { updatePageWithPostData(postDataToLoad); });
                }
                catch (InvalidOperationException invalidOperation)
                {
                    MessageBox.Show(invalidOperation.Message, @"Error");
                }
            }
        }

        private void fetchPostsDataInBackground()
        {
            lock(sr_PostDataLock)
            {
                try
                {
                    List<EnhancedPost> postDataToLoad = PageData.FeedPaged.CollectionData;

                    this.Invoke((MethodInvoker)delegate { updatePageWithPostData(postDataToLoad); });
                }
                catch(InvalidOperationException invalidOperation)
                {
                    MessageBox.Show(invalidOperation.Message, @"Error");
                }
            }
        }

        private void updatePageWithPostData(List<EnhancedPost> i_Data)
        {
            m_PostViewButton.Refresh();
        }

        private void updatePageWithNonPostData()
        {
            wallPageDataBindingSource.DataSource = PageData;
            
            if (PageData?.ProfilePicUrl != null)
            {
                profilePicture.LoadAsync(PageData.ProfilePicUrl);
            }

            if (PageData?.CoverPicUrl != null)
            {
                coverPicture.LoadAsync(PageData.CoverPicUrl);
                coverPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            m_FillNumberOfFriends.Text = PageData?.Friends.Count.ToString();
        }

        private void m_PostViewButton_ChangeConnectionRequest(object i_Sender, EventArgs i_EventArgs)
        {
            object selectedItem = (i_Sender as ComboBox)?.SelectedItem;

            if(selectedItem is ePostConnectionOptions connection)
            {
                new Thread(fetchPostsDataInBackground).Start();
            }
        }

        private void m_PostViewButton_MorePostsRequest(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchMorePostsDataInBackground).Start();
        }

        private void fetchMorePostsDataInBackground()
        {
            lock(sr_PostDataLock)
            {
                try
                {
                    PageData.FeedPaged.FetchNewPage();

                    List<EnhancedPost> postDataToLoad = PageData.FeedPaged.CollectionData;

                    this.Invoke((MethodInvoker)delegate { updatePageWithPostData(postDataToLoad); });
                }
                catch(InvalidOperationException invalidOperation)
                {
                    MessageBox.Show(invalidOperation.Message, @"Error");
                }
            }
        }

        private void m_PostViewButton_FilterRequest(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasDataInfo)i_Sender).ReceivedInfo = PageData.CurrentFilterData;
            OnReceivedInfo(i_Sender, i_EventArgs);
        }

        private void m_PostViewButton_LoadAllPosts(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchAllPostsDataInBackground).Start();
        }

        private void fetchAllPostsDataInBackground()
        {
            lock (sr_PostDataLock)
            {
                try
                {
                    PagedCollectionManager<EnhancedPost> pagedCollection = PageData.FeedPaged;

                    while(pagedCollection.FetchNewPage())
                    {
                        List<EnhancedPost> postDataToLoad = pagedCollection.CollectionData;

                        this.Invoke((MethodInvoker)delegate { updatePageWithPostData(postDataToLoad); });
                    }
                }
                catch (InvalidOperationException invalidOperation)
                {
                    MessageBox.Show(invalidOperation.Message, @"Error");
                }
            }
        }

        private void m_PostViewButton_PostSelected(object i_Sender, EventArgs i_EventArgs)
        {
            OnReceivedInfo(i_Sender, i_EventArgs);
        }

        private void m_PostViewButton_PostAnalyticRequest(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;
            OnChangePage(i_Sender, i_EventArgs);
        }

        private void m_ViewFriendButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasDataInfo)i_Sender).ReceivedInfo = m_ChooseFriend.ReceivedInfo;
            ((IHasDataInfo)i_Sender).InfoChoice = eInfoChoice.Friend;
            ((IHasSwitchPage)i_Sender).NewPageOwner = (EnhancedUser)m_ChooseFriend.ReceivedInfo;

            OnChangePage(i_Sender, i_EventArgs);
        }

        public void LoadFilterData(FilterData i_FilterDate)
        {
            PageData.CurrentFilterData = i_FilterDate;

            if(i_FilterDate.FilterByDate)
            {
                new Thread(fetchAllPostInDatesInBackground).Start();
            }
            else
            {
                new Thread(fetchPostsDataInBackground).Start();
            }
        }

        private void fetchAllPostInDatesInBackground()
        {
            lock (sr_PostDataLock)
            {
                try
                {
                    PageData.FeedPaged.TryToGetAllInDates
                        (PageData.CurrentFilterData.MaxDate, PageData.CurrentFilterData.MinDate);

                    List<EnhancedPost> postDataToLoad = PageData.FeedPaged.CollectionData;

                    this.Invoke((MethodInvoker)delegate { updatePageWithPostData(postDataToLoad); });
                }
                catch (InvalidOperationException invalidOperation)
                {
                    MessageBox.Show(invalidOperation.Message, @"Error");
                }
            }
        }
    }
}
