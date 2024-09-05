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
using FacebookPages.Code.Pages.Data.Post.Filter;

namespace FacebookPages.Pages.Data
{
    public class WallPageData : PageData
    {
        public string ProfilePicUrl { get; protected set; }
        public string CoverPicUrl { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public FacebookObjectCollection<User> Friends { get; protected set; }
        public PostsWithPaging<UpdatedPostData> PostsWithPaging { get; protected set; } = new PostsWithPaging<UpdatedPostData>();

        public override void TryFetchAndLoadPageData(
            UserFetchData i_FetchData = null, Dictionary<string, string> i_KeyValueParamtersPairs = null)
        {
            base.TryFetchAndLoadPageData(i_FetchData, i_KeyValueParamtersPairs);
            PostsWithPaging.Connection = "feed";
            PostsWithPaging.PageFetcherObject = this.PageFetcherObject;
            PostsWithPaging.TryFetchAndLoadPageData();
        }

        public void LoadUserWallData(User i_User)
        {
            DataFilter newFilter = new DataFilter();

            newFilter.UserSource = i_User;
            PostsWithPaging.FilterData = newFilter;
            newFilter.AvailableUsersToSelect.Add(i_User);

            foreach (User friend in i_User.Friends)
            {
                newFilter.AvailableUsersToSelect.Add(friend);
            }

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
