using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages.Data;
using FetchHandler.Fetch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FacebookPostsWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookPages.Pages.Data
{
    public class WallPageData : PageData
    {
        public string ProfilePicUrl { get; set; }
        public string CoverPicUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FacebookPostWrapper Posts { get; private set; }

        public override void FetchAndLoadData(UserFetchData i_Fetcher)
        {
            Fetcher fetchHandler = new Fetcher(i_Fetcher);
            Posts = fetchHandler.FetchToObj<FacebookPostWrapper>
                ("posts{id,message,story," +
                "created_time,updated_time," +
                "place,full_picture,link,attachments," +
                "from{name,id},to{id,name}," +
                "reactions.limit(1000).summary(false)," +
                "comments.limit(1000).summary(true),shares," +
                "insights.metric(post_impressions,post_engaged_users)," +
                "status_type,type,is_popular,application{namespace,name}" +
                ",event{name,place,owner,start_time,end_time}}");
        }

        public void LoadUserWallData(User i_User)
        {
            CoverPicUrl =
                i_User?.Albums
                .FirstOrDefault<Album>(
                    T => String.Equals(T.Name, "Cover photos", StringComparison.OrdinalIgnoreCase)
                    )?
                    .CoverPhoto
                    .PictureNormalURL;
            ProfilePicUrl = i_User?.PictureLargeURL;
            FirstName = i_User?.FirstName;
            LastName = i_User?.LastName;
        }
    }
}
