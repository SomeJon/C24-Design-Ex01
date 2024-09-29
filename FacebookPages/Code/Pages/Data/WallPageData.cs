using System;
using System.Collections.Generic;
using System.Linq;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Code.Pages.Data.Post.Filter;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;

namespace FacebookPages.Code.Pages.Data
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

            FacebookObjectCollectionWithPaging<UpdatedPostData> test = 
                FacebookServicesEnhancements.GetCollection<UpdatedPostData>("feed", PageFetcherObject, 
                    Post.PostsWithPaging<UpdatedPostData>.sr_FieldsToLoad[eLoadOptions.Full]);
        }

        public void LoadUserWallData(User i_User)
        {
            DataFilter newFilter = new DataFilter { UserSource = i_User };

            PostsWithPaging.FilterData = newFilter;
            newFilter.AvailableUsersToSelect.Add(i_User);

            if(i_User != null)
            {
                foreach(User friend in i_User.Friends)
                {
                    newFilter.AvailableUsersToSelect.Add(friend);
                }

                CoverPicUrl = i_User.Albums
                    .FirstOrDefault(i_Album => 
                        string.Equals(i_Album.Name, "Cover photos", StringComparison.OrdinalIgnoreCase))
                    ?.CoverPhoto.PictureNormalURL;
                ProfilePicUrl = i_User.PictureLargeURL;
                FirstName = i_User.FirstName;
                LastName = i_User.LastName;
                Friends = i_User.Friends;
            }
        }
    }
}
