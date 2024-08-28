using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookPages.Code.Pages.Data.Post.Filter
{
    public static class FilterMethod
    {
        public enum eFilterCondition
        {
            Links,
            Status,
            Photo,
            ContainsPhoto
        }

        public static Func<UpdatedPostData, bool> GetCombinedFilter(List<eFilterCondition> i_FilterConditions)
        {
            Func<UpdatedPostData, bool> combinedFilter = i_PostData => true;

            if (i_FilterConditions == null || i_FilterConditions.Count == 0)
            {
                return combinedFilter; // No filters applied, return all posts
            }

            foreach (eFilterCondition condition in i_FilterConditions)
            {
                Func<UpdatedPostData, bool> currentFilter = GetFilter(condition);
                combinedFilter = combineFilters(combinedFilter, currentFilter);
            }

            return combinedFilter;
        }

        private static Func<UpdatedPostData, bool> GetFilter(eFilterCondition i_FilterCondition)
        {
            switch (i_FilterCondition)
            {
                case eFilterCondition.Links:
                    return filterByLink;
                case eFilterCondition.Status:
                    return filterByStatus;
                case eFilterCondition.Photo:
                    return filterByPhoto;
                case eFilterCondition.ContainsPhoto:
                    return filterByContainsPhoto;
                default:
                    throw new ArgumentException("Invalid filter condition", nameof(i_FilterCondition));
            }
        }

        private static bool filterByLink(UpdatedPostData i_PostData)
        {
            return i_PostData.Type == FacebookWrapper.ObjectModel.Post.eType.link;
        }

        private static bool filterByStatus(UpdatedPostData i_PostData)
        {
            return i_PostData.Type == FacebookWrapper.ObjectModel.Post.eType.status;
        }

        private static bool filterByPhoto(UpdatedPostData i_PostData)
        {
            return i_PostData.Type == FacebookWrapper.ObjectModel.Post.eType.photo;
        }

        private static bool filterByContainsPhoto(UpdatedPostData i_PostData)
        {
            return string.IsNullOrEmpty(i_PostData.ImageUrl);
        }

        private static Func<UpdatedPostData, bool> combineFilters
            (Func<UpdatedPostData, bool> i_FirstFilter, Func<UpdatedPostData, bool> i_SecondFilter)
        {
            return i_PostData => i_FirstFilter(i_PostData) && i_SecondFilter(i_PostData);
        }
    }
}
