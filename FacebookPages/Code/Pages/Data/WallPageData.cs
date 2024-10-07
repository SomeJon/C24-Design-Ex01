using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Code.Pages.Data.UserManager;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;
using static FacebookWrapperEnhancements.Code.EnhancedObjects.EnhancedPost;

namespace FacebookPages.Code.Pages.Data
{
    public class WallPageData : IPageData
    {
        private FilterData m_CurrentFilterData;
        private FacebookObjectCollection<EnhancedUser> m_Friends;
        public EnhancedUser PageUser { get; }
        public string ProfilePicUrl { get; protected set; }
        public string CoverPicUrl { get; protected set; }
        public string FullName { get; protected set; }
        public FacebookObjectCollection<EnhancedUser> Friends => m_Friends ?? (m_Friends = PageUser.Friends);
        public FilterData CurrentFilterData
        {
            get
            {
                if (m_CurrentFilterData == null)
                {
                    m_CurrentFilterData = new FilterData { UserSource = PageUser };

                    m_CurrentFilterData.AvailableUsersToSelect.Add(PageUser);
                    foreach (EnhancedUser friend in PageUser.Friends)
                    {
                        m_CurrentFilterData.AvailableUsersToSelect.Add(friend);
                    }
                }

                return m_CurrentFilterData;
            }
            set
            {
                m_CurrentFilterData = value;
                CurrentPageFeed = UserDataManager.GetUserData(CurrentFilterData.UserSource).WallData.PageUserFeed;
            }
        }
        public PagedCollection<EnhancedPost> Feed => CurrentPageFeed.GetPosts(CurrentFilterData);
        public List<EnhancedPost> FeedList => CurrentPageFeed.GetPosts(CurrentFilterData).CollectionData;
        public PostAnalyticData PostAnalyticData => new PostAnalyticData
            (Feed.CollectionData, PageUser);
        public UserPostFeed PageUserFeed { get; }
        public UserPostFeed CurrentPageFeed { get; internal set; }


        internal WallPageData(EnhancedUser i_PageUser)
        {
            if(i_PageUser != null)
            {
                PageUser = i_PageUser;
                PageUserFeed = new UserPostFeed(PageUser);
                CurrentPageFeed = PageUserFeed;
            }
            else
            {
                throw new ArgumentNullException(nameof(i_PageUser), "A user was not recieved!");
            }

        }

        public void LoadAllCurrentData()
        {
            FetchNonPostsData();
        }

        public void RefreshData()
        {
            m_Friends = null;
            LoadAllCurrentData();
        }

        public void FetchNonPostsData()
        {
            CoverPicUrl = PageUser.Albums
                .FirstOrDefault(
                    i_Album => string.Equals(i_Album.Name, "Cover photos", 
                        StringComparison.OrdinalIgnoreCase))
                ?.CoverPhoto.PictureNormalURL;
            ProfilePicUrl = PageUser.PictureLargeURL;
            FullName = PageUser.Name;
            m_Friends = PageUser.Friends;
        }

        
    }
}
