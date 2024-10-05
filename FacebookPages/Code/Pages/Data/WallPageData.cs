using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;

namespace FacebookPages.Code.Pages.Data
{
    public class WallPageData : IPageData
    {
        public string ProfilePicUrl { get; protected set; }
        public string CoverPicUrl { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public FacebookObjectCollection<User> Friends { get; protected set; }
        public FacebookObjectCollectionWithPaging<EnhancedUser> PostsWithPaging { get; protected set; } 
            = new FacebookObjectCollectionWithPaging<EnhancedUser>();



        public void LoadUserWallData(User i_User)
        {
            FilterData newFilter = new FilterData { UserSource = i_User };

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

        public void LoadAllCurrentData()
        {
            throw new NotImplementedException();
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

        public EnhancedUser PageUser { get; set; }
    }
}
