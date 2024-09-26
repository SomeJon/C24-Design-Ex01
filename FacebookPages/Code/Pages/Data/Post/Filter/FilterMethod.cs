using System;
using System.Collections.Generic;
using System.Linq;

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
            (Dictionary<eFilterCondition, bool> iFilterConditions,
                string iContainTextString = null)
        {
            if (iFilterConditions == null || iFilterConditions.Count == 0)
            {
                return iPostData => true;
            }

            if (!string.IsNullOrEmpty(iContainTextString))
            {
                ContainTextString = iContainTextString;
            }

            var activeFilters = iFilterConditions
                .Where(filter => filter.Value)
                .Select(filter => getFilter(filter.Key))
                .ToList();

            if (activeFilters.Count == 0)
            {
                return iPostData => true;
            }

            return iPostData =>
            {
                return MatchAllFilters
                    ? activeFilters.All(filter => filter(iPostData))
                    : activeFilters.Any(filter => filter(iPostData));
            };
        }


        private static Func<UpdatedPostData, bool> getFilter(eFilterCondition iFilterCondition)
        {
            switch (iFilterCondition)
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
                    return iPostData => true;
            }
        }


        private static bool filterByLink(UpdatedPostData iPostData)
        {
            return iPostData.Type == FacebookWrapper.ObjectModel.Post.eType.link;
        }

        private static bool filterByStatus(UpdatedPostData iPostData)
        {
            return iPostData.Type == FacebookWrapper.ObjectModel.Post.eType.status;
        }

        private static bool filterByPhoto(UpdatedPostData iPostData)
        {
            return iPostData.Type == FacebookWrapper.ObjectModel.Post.eType.photo;
        }

        private static bool filterByContainsPhoto(UpdatedPostData iPostData)
        {
            return !string.IsNullOrEmpty(iPostData.ImageUrl);
        }

        private static bool filterByContainsText(UpdatedPostData iPostData)
        {
            return !string.IsNullOrEmpty(iPostData.Message) && 
                iPostData.Message.Contains(ContainTextString);
        }
    }
}
