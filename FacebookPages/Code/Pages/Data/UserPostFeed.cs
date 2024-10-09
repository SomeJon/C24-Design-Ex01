using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using System;
using FacebookWrapperEnhancements.Code.Collection.Filter;

namespace FacebookPages.Code.Pages.Data
{
    public class UserPostFeed : IPageData
    {
        public enum ePostConnectionOptions
        {
            Feed,
            Posts
        }

        private PagedCollectionManager<EnhancedPost> m_WallPosts;
        private PagedCollectionManager<EnhancedPost> m_UserPosts;
        public EnhancedUser PageUser { get; }
        public ePostConnectionOptions CurrentConnection { get; set; } = ePostConnectionOptions.Feed;
        public PagedCollectionManager<EnhancedPost> WallPosts
        {
            get
            {
                if (m_WallPosts == null)
                {
                    FetchWallPostsData();
                }

                return m_WallPosts;
            }
        }
        public PagedCollectionManager<EnhancedPost> UserPosts
        {
            get
            {
                if (m_UserPosts == null)
                {
                    FetchUserPostsData();
                }

                return m_UserPosts;
            }
        }


        internal UserPostFeed(EnhancedUser i_PageUser)
        {
            PageUser = i_PageUser ?? throw
                           new ArgumentNullException(nameof(i_PageUser), "A user was not recieved!");
        }

        public void LoadAllCurrentData()
        {
            FetchWallPostsData();
            FetchUserPostsData();
        }

        public void RefreshData()
        {
            m_UserPosts = null;
            m_WallPosts = null;
        }

        public PagedCollectionManager<EnhancedPost> GetPosts(FilterData i_FilterData)
        {
            PagedCollectionManager<EnhancedPost> returningCollection;

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
                    break;
            }

            returningCollection.FilterStrategy = i_FilterData.GetPostFilterStrategy();
            returningCollection.SortStrategy = i_FilterData.GetPostSortStrategy();
            return returningCollection;
        }

        public void FetchWallPostsData()
        {
            m_WallPosts = new PagedCollectionManager<EnhancedPost>(PageUser.Feed, PageUser.Id);
        }

        public void FetchUserPostsData()
        {
            m_UserPosts = new PagedCollectionManager<EnhancedPost>(PageUser.Posts, PageUser.Id);
        }
    }
}