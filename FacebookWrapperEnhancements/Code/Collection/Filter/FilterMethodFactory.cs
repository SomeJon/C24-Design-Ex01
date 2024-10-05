using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapperEnhancements.Code.Collection.Filter.Strategy;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public static class FilterMethod
    {
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

        public static Predicate<EnhancedPost> GetCombinedFilter(
            Dictionary<eFilterCondition, bool> i_FilterConditions,
            string i_ContainTextString = null)
        {
            if (i_FilterConditions == null || i_FilterConditions.Count == 0)
            {
                return i_PostData => true; 
            }

            List<Predicate<EnhancedPost>> activeFilters = i_FilterConditions
                .Where(i_Filter => i_Filter.Value)
                .Select(i_Filter => getFilterStrategy(i_Filter.Key, i_ContainTextString).GetPredicate())
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

        private static IFilterStrategy getFilterStrategy(eFilterCondition i_FilterCondition, string i_ContainTextString)
        {
            switch (i_FilterCondition)
            {
                case eFilterCondition.Links:
                    return new LinksFilterStrategy();
                case eFilterCondition.Status:
                    return new StatusFilterStrategy();
                case eFilterCondition.Photo:
                    return new PhotoFilterStrategy();
                case eFilterCondition.ContainsPhoto:
                    return new ContainsPhotoFilterStrategy();
                case eFilterCondition.ContainsText:
                    return new ContainsTextFilterStrategy(i_ContainTextString);
                default:
                    return new DefaultFilterStrategy();
            }
        }
    }

}
