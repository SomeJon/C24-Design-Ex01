using FacebookPages.Code.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            UserFetchData iFetchData = null, Dictionary<string, string> iKeyValueParamtersPairs = null)
        {
            base.TryFetchAndLoadPageData(iFetchData, iKeyValueParamtersPairs);
            PostsWithPaging.Connection = "feed";
            PostsWithPaging.PageFetcherObject = this.PageFetcherObject;
            PostsWithPaging.TryFetchAndLoadPageData();
        }

        public void LoadUserWallData(User iUser)
        {
            DataFilter newFilter = new DataFilter();

            newFilter.UserSource = iUser;
            PostsWithPaging.FilterData = newFilter;
            newFilter.AvailableUsersToSelect.Add(iUser);

            foreach (User friend in iUser.Friends)
            {
                newFilter.AvailableUsersToSelect.Add(friend);
            }

            CoverPicUrl =
                iUser?.Albums
                .FirstOrDefault<Album>(
                    T => String.Equals(T.Name, "Cover photos", StringComparison.OrdinalIgnoreCase)
                    )?
                    .CoverPhoto
                    .PictureNormalURL;
            ProfilePicUrl = iUser?.PictureLargeURL;
            FirstName = iUser?.FirstName;
            LastName = iUser?.LastName;
            Friends = iUser?.Friends;
        }
    }
}
