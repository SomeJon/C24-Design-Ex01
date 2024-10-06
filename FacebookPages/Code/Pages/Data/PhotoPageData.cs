using FacebookWrapperEnhancements.Code.EnhancedObjects;
using System;
using FacebookWrapper.ObjectModel;
using System.Reflection;

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
            PropertyInfo[] properties = typeof(AboutMePageData).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this); //Forces the lazy load to load
            }
        }

        public void RefreshData()
        {
            LoadAllCurrentData();
        }
    }
}