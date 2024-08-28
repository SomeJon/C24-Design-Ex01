using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FacebookWrapper.ObjectModel;

namespace FacebookPages.Code.Pages.Data.Post.Filter
{
    public static class FilterMethod
    {
        public static string ContainTextString { get; set; } = string.Empty;
        public static bool MatchAllFilters { get; set; } = false;
        public enum eFilterCondition
        {
            Links,
            Status,
            Photo,
            ContainsPhoto,
            ContainsText
        }

        public static Func<UpdatedPostData, bool> GetCombinedFilter
            (Dictionary<eFilterCondition, bool> i_FilterConditions, string i_ContainTextString = null)
        {
            Func<UpdatedPostData, bool> combinedFilter = i_PostData => true;

            if (i_FilterConditions == null || i_FilterConditions.Count == 0)
            {
                return combinedFilter; // No filters applied, return all posts
            }

            if (!string.IsNullOrEmpty(i_ContainTextString))
            {
                ContainTextString = i_ContainTextString;
            }

            foreach (var filterCondition in i_FilterConditions)
            {
                if (filterCondition.Value) // Only apply the filter if the condition is set to true
                {
                    Func<UpdatedPostData, bool> currentFilter = GetFilter(filterCondition.Key);
                    combinedFilter = combineFilters(combinedFilter, currentFilter);
                }
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
                case eFilterCondition.ContainsText:
                    return filterByContainsText;
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
            return !string.IsNullOrEmpty(i_PostData.ImageUrl);
        }

        private static bool filterByContainsText(UpdatedPostData i_PostData)
        {
            return !string.IsNullOrEmpty(i_PostData.Message) && 
                i_PostData.Message.Contains(ContainTextString);
        }

        private static Func<UpdatedPostData, bool> combineFilters
            (Func<UpdatedPostData, bool> i_FirstFilter, Func<UpdatedPostData, bool> i_SecondFilter)
        {
            if (MatchAllFilters)
            {
                return i_PostData => i_FirstFilter(i_PostData) && i_SecondFilter(i_PostData);
            }
            else
            {
                return i_PostData => i_FirstFilter(i_PostData) || i_SecondFilter(i_PostData);
            }
        }
    }
}
