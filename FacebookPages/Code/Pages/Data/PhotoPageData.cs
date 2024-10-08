using FacebookWrapperEnhancements.Code.EnhancedObjects;
using System;
using FacebookWrapper.ObjectModel;

namespace FacebookPages.Code.Pages.Data
{
    public class PhotoPageData : IPageData
    {
        public EnhancedUser PageUser { get; }
        public FacebookObjectCollection<Album> Albums => PageUser.Albums;


        internal PhotoPageData(EnhancedUser i_PageUser)
        {
            PageUser = i_PageUser ?? throw 
                           new ArgumentNullException(nameof(i_PageUser), "A user was not recieved!");

        }

        public void LoadAllCurrentData()
        {
            object forceLoad = Albums;
        }

        public void RefreshData()
        {
            LoadAllCurrentData();
        }
    }
}