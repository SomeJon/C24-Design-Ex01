using FetchHandler.Fetch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FacebookDataWrapper;

namespace FacebookPages.Code.Pages.Data
{
    public class FriendsPageData : PageData
    { 
        
        public FacebookFriendsResponse Data { get; set; }

        public override void FetchAndLoadData(UserFetchData i_Fetcher)
        {
            Fetcher fetchHandler = new Fetcher(i_Fetcher);
            Data = fetchHandler.FetchToObj<FacebookFriendsResponse>
                ("fields=id,name,picture.width(400).height(400)", "friends");
        }
    }
}
