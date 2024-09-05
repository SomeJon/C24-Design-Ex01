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
            DateFilter,
            ContainsText
        }

        public static Func<UpdatedPostData, bool> GetCombinedFilter
            (Dictionary<eFilterCondition, bool> i_FilterConditions,
                string i_ContainTextString = null)
        {
            if (i_FilterConditions == null || i_FilterConditions.Count == 0)
            {
                return i_PostData => true;
            }

            if (!string.IsNullOrEmpty(i_ContainTextString))
            {
                ContainTextString = i_ContainTextString;
            }

            var activeFilters = i_FilterConditions
                .Where(filter => filter.Value)
                .Select(filter => GetFilter(filter.Key))
                .ToList();

            if (activeFilters.Count == 0)
            {
                return i_PostData => true;
            }

            return i_PostData =>
            {
                return MatchAllFilters
                    ? activeFilters.All(filter => filter(i_PostData))
                    : activeFilters.Any(filter => filter(i_PostData));
            };
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
                    return i_PostData => true;
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
    }
}
