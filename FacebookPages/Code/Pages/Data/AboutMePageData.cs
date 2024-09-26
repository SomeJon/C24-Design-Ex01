using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookPages.Code.Pages.Data
{
    public class AboutMePageData : PageData
    {
        private City m_Location;
        private City m_Hometown;
        public string Birthday
        {
            get
            {
                return m_DynamicData.birthday;
            }
        }
        public City Location 
        {
            get
            {
            return WrapOrGet<City>(ref m_Location, m_DynamicData.location, eLoadOptions.Full);
            }
        }
        public string Email
        {
            get
            {
                return m_DynamicData.email;
            }
        }
        public string Gender
        {
            get
            {
                return m_DynamicData.gender;
            }
        }
        public City Hometown
        {
            get
            {
                return WrapOrGet<City>(ref m_Hometown, m_DynamicData.hometown, eLoadOptions.Full);
            }
        }
        public string Name
        {
            get
            {
                return m_DynamicData.name;
            }
        }


        private static readonly Dictionary<eLoadOptions, string> SrFieldsToLoad = new Dictionary<eLoadOptions, string>
        {
        {
            eLoadOptions.None,
            "id, name"
        },
        {
            eLoadOptions.Basic,
            "birthday,location{location},email,gender,hometown,name"
        },
        {
            eLoadOptions.Full,
            "birthday,location{location},email,gender,hometown,name"
        },
        {
            eLoadOptions.FullWithConnections,
            "birthday,location{location},email,gender,hometown,name"
        }
        };

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => SrFieldsToLoad;

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            m_Hometown = null;
            m_Location = null;
        }
    }
}
