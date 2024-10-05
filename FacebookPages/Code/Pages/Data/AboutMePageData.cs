using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using static FacebookWrapper.ObjectModel.DynamicWrapper;
using System.Reflection;

namespace FacebookPages.Code.Pages.Data
{
    public class AboutMePageData : IPageData
    {
        public EnhancedUser PageUser { get; }
        public string Birthday => PageUser?.Birthday;

        public City Location => PageUser?.Location;

        public string Email => PageUser?.Email;

        public string Gender => PageUser?.Gender?.ToString();

        public City Hometown => PageUser?.Hometown;

        public string FullName => PageUser?.Name;


        public AboutMePageData(EnhancedUser i_PageUser)
        {
            PageUser = i_PageUser;
        }

        public void LoadAllCurrentData()
        {
            PropertyInfo[] properties = typeof(AboutMePageData).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this);
            }
        }

        public void RefreshData()
        {
            LoadAllCurrentData();
        }
    }
}
