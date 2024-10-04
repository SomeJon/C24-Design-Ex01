using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.EnhancedObjects
    {
    public class EnhancedUser : User
    {
        private FacebookObjectCollectionWithPaging<User> m_LikedPages;
        private FacebookObjectCollectionWithPaging<EnhancedAlbums> m_Albums;
        private FacebookObjectCollection<EnhancedPost> m_Posts;

        public FacebookObjectCollection<EnhancedPost> Posts
        {
            get => RetrieveCollection("feed?filter=app_2915120374", ref m_Posts, EnhancedPost.sr_FieldsToLoad[eLoadOptions.Full]);
            set => m_Posts = value;
        }

        public FacebookObjectCollectionWithPaging<User> LikedPages
        {
            get => FacebookServicesEnhancements.RetrieveCollection("likes", ref m_LikedPages, 
                Id, Group.sr_FieldsToLoad[eLoadOptions.Full]);
            set => m_LikedPages = value;
        }

        public FacebookObjectCollectionWithPaging<EnhancedAlbums> Albums
        {
            get => FacebookServicesEnhancements.RetrieveCollection("albums", ref m_Albums, 
                Id, Album.sr_FieldsToLoad[eLoadOptions.Full]);
            set => m_Albums = value;
        }


    }
}
