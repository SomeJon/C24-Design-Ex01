//using Facebook;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using FetchHandler.Fetch;
//using System.Threading.Tasks;
//using FetchHandler.Fetch.About;
//using FacebookPages.Code.Pages.Data;
//using FacebookWrapper;

//namespace FacebookPages.Pages.Data
//{
//    public class AboutMePageData2 : PageData
//    {
//        public string City { get; set; }
//        public string Country { get; set; }
//        public string Birthday { get; set; }
//        public string FullName { get; set; }
//        public string HomeTown { get; set; }
//        public string Email { get; set; }
//        public string Gender { get; set; }

//        public override void FetchAndLoadData(UserFetchData i_Fetcher)
//        {
//            Fetcher fetchHandler = new Fetcher(i_Fetcher);
//            AboutDataWarpper userData = fetchHandler.FetchToObj<AboutDataWarpper>
//                ("birthday,location{location},email,gender,hometown,name");

//            City = userData.Location.Location.City;
//            Country = userData.Location.Location.Country;
//            Birthday = userData.Birthday;
//            FullName = userData.Name;
//            HomeTown = userData.Hometown.Name;
//            Email = userData.Email;
//            Gender = userData.Gender;

            
//        }
//    }
//}
