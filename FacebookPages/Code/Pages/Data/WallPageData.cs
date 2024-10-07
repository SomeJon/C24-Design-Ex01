using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using FacebookPages.Code.Pages.Data.Post;
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
        private PagedCollection<EnhancedPost> m_WallPosts;
        private PagedCollection<EnhancedPost> m_UserPosts;
        private FacebookObjectCollection<EnhancedUser> m_Friends;
        public ePostConnectionOptions CurrentConnection { get; set; } = ePostConnectionOptions.Feed;
        public EnhancedUser PageUser { get; }
        public string ProfilePicUrl { get; protected set; }
        public string CoverPicUrl { get; protected set; }
        public string FullName { get; protected set; }
        public FacebookObjectCollection<EnhancedUser> Friends => m_Friends ?? (m_Friends = PageUser.Friends);
        public PagedCollection<EnhancedPost> WallPosts
        {
            get
            {
                if(m_WallPosts == null)
                {
                    FetchWallPostsData();
                }

                Debug.Assert(m_WallPosts != null, nameof(m_WallPosts) + " != null");
                m_WallPosts.FilterStrategy = CurrentFilterData.GetPostFilterStrategy();
                m_WallPosts.SortStrategy = CurrentFilterData.GetPostSortStrategy();

                return m_WallPosts;
            }
        }
        public PagedCollection<EnhancedPost> UserPosts
        {
            get
            {
                if(m_UserPosts == null)
                {
                    FetchUserPostsData();
                }

                Debug.Assert(m_UserPosts != null, nameof(m_UserPosts) + " != null");
                m_UserPosts.FilterStrategy = CurrentFilterData.GetPostFilterStrategy();
                m_UserPosts.SortStrategy = CurrentFilterData.GetPostSortStrategy();

                return m_UserPosts;
            }
        }
        public FilterData CurrentFilterData { get; set; }
        public PostAnalyticData PostAnalyticData => new PostAnalyticData(GetPosts().CollectionData, PageUser);


        internal WallPageData(EnhancedUser i_PageUser)
        {
            PageUser = i_PageUser ?? throw 
                           new ArgumentNullException(nameof(i_PageUser), "A user was not recieved!");
        }

        public void LoadAllCurrentData()
        {
            FetchNonPostsData();
            FetchWallPostsData();
            FetchUserPostsData();
        }

        public void RefreshData()
        {
            m_UserPosts = null;
            m_WallPosts = null;
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

        public void FetchWallPostsData()
        {
            if(CurrentFilterData == null)
            {
                CurrentFilterData = new FilterData { UserSource = PageUser };

                CurrentFilterData.AvailableUsersToSelect.Add(PageUser);
                foreach(EnhancedUser friend in PageUser.Friends)
                {
                    CurrentFilterData.AvailableUsersToSelect.Add(friend);
                }
            }


            m_WallPosts = new PagedCollection<EnhancedPost>(PageUser.Feed, PageUser.Id);
        }

        public void FetchUserPostsData()
        {
            if (CurrentFilterData == null)
            {
                CurrentFilterData = new FilterData { UserSource = PageUser };

                CurrentFilterData.AvailableUsersToSelect.Add(PageUser);
                foreach (EnhancedUser friend in PageUser.Friends)
                {
                    CurrentFilterData.AvailableUsersToSelect.Add(friend);
                }
            }

            m_UserPosts = new PagedCollection<EnhancedPost>(PageUser.Posts, PageUser.Id)
                            {
                                FilterStrategy = CurrentFilterData.GetPostFilterStrategy(),
                                SortStrategy = CurrentFilterData.GetPostSortStrategy()
                            };
        }

        public PagedCollection<EnhancedPost> GetPosts()
        {
            PagedCollection<EnhancedPost> returningCollection;

            switch (CurrentConnection)
            {
                case ePostConnectionOptions.Feed:
                    returningCollection = WallPosts;
                    break;
                case ePostConnectionOptions.Posts:
                    returningCollection = UserPosts;
                    break;
                default:
                    returningCollection = WallPosts;
                    CurrentConnection = ePostConnectionOptions.Feed;
                    break;
            }

            return returningCollection;
        }
    }
}
