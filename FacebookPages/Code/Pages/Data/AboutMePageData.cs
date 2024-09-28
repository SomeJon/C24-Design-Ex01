using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookPages.Code.Pages.Data
{
    public class AboutMePageData : PageData
    {
        private City m_Location;
        private City m_Hometown;
        public string Birthday => m_DynamicData.birthday;

        public City Location => 
            WrapOrGet<City>(ref m_Location, m_DynamicData.location, eLoadOptions.Full);

        public string Email => m_DynamicData.email;

        public string Gender => m_DynamicData.gender;

        public City Hometown => 
            WrapOrGet<City>(ref m_Hometown, m_DynamicData.hometown, eLoadOptions.Full);

        public string Name => m_DynamicData.name;


        private static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoad = new Dictionary<eLoadOptions, string>
            {
                { eLoadOptions.None, "id, name" },
                { eLoadOptions.Basic, "birthday,location{location},email,gender,hometown,name" },
                { eLoadOptions.Full, "birthday,location{location},email,gender,hometown,name" },
                { eLoadOptions.FullWithConnections, "birthday,location{location},email,gender,hometown,name" }
            };

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => sr_FieldsToLoad;

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            m_Hometown = null;
            m_Location = null;
        }
    }
}
