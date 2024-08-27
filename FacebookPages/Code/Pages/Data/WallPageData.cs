using FacebookPages.Code.Pages.Data;
using FacebookPages.Pages.Data;
using FetchHandler.Fetch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookPages.Code.Pages.Data.Post;

namespace FacebookPages.Pages.Data
{
    public class WallPageData : PageData
    {
        public string ProfilePicUrl { get; protected set; }
        public string CoverPicUrl { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public FacebookObjectCollection<User> Friends { get; protected set; }
        public PostsWithPaging<UpdatedPostData> Posts { get; protected set; } = new PostsWithPaging<UpdatedPostData>();

        public override void TryFetchAndLoadPageData(
            UserFetchData i_FetchData = null, Dictionary<string, string> i_KeyValueParamtersPairs = null)
        {
            base.TryFetchAndLoadPageData(i_FetchData, i_KeyValueParamtersPairs);
            Posts.Connection = "feed";
            Posts.PageFetcherObject = this.PageFetcherObject;
            Posts.TryFetchAndLoadPageData();
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
            Friends = i_User?.Friends;
        }
    }
}
