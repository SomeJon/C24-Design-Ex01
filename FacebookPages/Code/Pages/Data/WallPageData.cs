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
        public string ProfilePicUrl { get; set; }
        public string CoverPicUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostsWithPaging { get; set; }

        public override void FetchAndLoadData()
        {
            PostsWithPaging tryThis = new PostsWithPaging();
            tryThis.Connection = "posts";
            tryThis.TryFetchAndLoadData(PageFetcherObject.UserFetchData);
            tryThis.Posts[0].ToString();
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
