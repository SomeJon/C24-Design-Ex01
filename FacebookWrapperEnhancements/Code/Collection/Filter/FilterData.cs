using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public class FilterData
    {
        public User UserSource { get; set; }
        public List<User> AvailableUsersToSelect { get; set; } = new List<User>();
        public Dictionary<FilterMethod.eFilterCondition, bool> Conditions { get; set; } = 
            new Dictionary<FilterMethod.eFilterCondition, bool>();
        public DateTime MinDate { get; set; } = 
            new System.DateTime
                (1900, 1, 1, 0, 0, 0, 0);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public EnhancedPostSortingMethodFactory.eSortingMethod PostSortingMethod { get; set; } = 
            EnhancedPostSortingMethodFactory.eSortingMethod.ByDatePublished;
        public bool ReverseOrder { get; set; } = false;
        public bool MatchAllFilters { get; set; } = false;
        public string TextContainsString { get; set; } = null;

        public static long ToUnixTimestamp(DateTime i_DateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(i_DateTime.ToUniversalTime());
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        // Method to generate a Predicate<EnhancedPost> based on filter conditions
        public Predicate<EnhancedPost> GetPredicate()
        {
            return FilterMethod.GetCombinedFilter(Conditions, TextContainsString);
        }

        // Method to generate a Comparison<EnhancedPost> based on sorting method and reverse order flag
        public Comparison<EnhancedPost> GetComparison()
        {
            Comparison<EnhancedPost> baseComparison = EnhancedPostSortingMethodFactory.GetComparison(PostSortingMethod);

            if (ReverseOrder)
            {
                // If ReverseOrder is true, reverse the comparison
                return (firstPost, secondPost) => baseComparison(secondPost, firstPost);
            }

            return baseComparison;
        }

    }
}
