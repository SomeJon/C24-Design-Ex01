using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection;

namespace FacebookWrapperEnhancements.Code.EnhancedObjects
{
    public class EnhancedAlbums : Album
    {
        private FacebookObjectCollectionWithPaging<Photo> m_Photos;
        public FacebookObjectCollectionWithPaging<Photo> PhotosWithPaging => 
            FacebookServicesEnhancements.RetrieveCollection("photos", 
                ref m_Photos, Id, Photo.sr_FieldsToLoad[eLoadOptions.Full]);
    }
}
