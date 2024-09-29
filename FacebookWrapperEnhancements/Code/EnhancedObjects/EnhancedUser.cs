using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;

namespace FacebookWrapperEnhancements.Code.UserManagement
{
    public class EnhancedUser : User
    {
        private FacebookObjectCollectionWithPaging<User> m_LikedPages;
        private FacebookObjectCollectionWithPaging<EnhancedAlbums> m_Albums;

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
