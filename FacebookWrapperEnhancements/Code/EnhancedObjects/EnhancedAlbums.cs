using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection;
using FetchHandler.Fetch;

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
