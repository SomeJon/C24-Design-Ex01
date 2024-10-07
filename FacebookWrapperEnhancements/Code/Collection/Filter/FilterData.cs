using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using static FacebookWrapperEnhancements.Code.Collection.Sort.SortingMethodFactory;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public class FilterData
    {
        public EnhancedUser UserSource { get; set; }
        public List<User> AvailableUsersToSelect { get; set; } = new List<User>();
        public Dictionary<FilterMethod.eFilterCondition, bool> Conditions =>
            new Dictionary<FilterMethod.eFilterCondition, bool>()
                {
                    { FilterMethod.eFilterCondition.Links, FilterOptions["Filter by Links"] },
                    { FilterMethod.eFilterCondition.Status, FilterOptions["Filter by Status"] },
                    { FilterMethod.eFilterCondition.Photo, FilterOptions["Filter by Photo"] },
                    { FilterMethod.eFilterCondition.ContainsPhoto, FilterOptions["Filter by Posts Containing Photos"] },
                    { FilterMethod.eFilterCondition.DateFilter, FilterOptions["Filter by Date"] },
                    { FilterMethod.eFilterCondition.ContainsText, FilterOptions["Filter by Text Containment"] }
                };
        public Dictionary<string, bool> FilterOptions { get; set; } =
            new Dictionary<string, bool>
                {
                    { "Filter by Links", false },
                    { "Filter by Status", false },
                    { "Filter by Photo", false },
                    { "Filter by Posts Containing Photos", false },
                    { "Filter by Date", false },
                    { "Filter by Text Containment", false }
                };
        public DateTime MinDate { get; set; } =
            new System.DateTime
                (1900, 1, 1, 0, 0, 0, 0);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public SortingMethodFactory.eSortingMethod PostSortingMethod { get; set; } =
            SortingMethodFactory.eSortingMethod.ByDatePublished;
        public bool ReverseOrder { get; set; } = false;
        public bool MatchAllFilters { get; set; } = false;
        public string TextContainsString { get; set; } = null;

        public static long ToUnixTimestamp(DateTime i_DateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(i_DateTime.ToUniversalTime());
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        public FilterData DeepClone()
        {
            FilterData clone = new FilterData
                                   {
                                       UserSource = this.UserSource,
                                       AvailableUsersToSelect = new List<User>(this.AvailableUsersToSelect),
                                       FilterOptions = new Dictionary<string, bool>(this.FilterOptions),
                                       MinDate = this.MinDate,
                                       MaxDate = this.MaxDate,
                                       PostSortingMethod = this.PostSortingMethod,
                                       ReverseOrder = this.ReverseOrder,
                                       MatchAllFilters = this.MatchAllFilters,
                                       TextContainsString = this.TextContainsString
                                   };

            return clone;
        }

        // Method to generate a Predicate<EnhancedPost> based on filter conditions
        public Predicate<EnhancedPost> GetPostFilterStrategy()
        {
            FilterMethod.MatchAllFilters = MatchAllFilters;
            return FilterMethod.GetCombinedFilter(Conditions, TextContainsString);
        }

        // Method to generate a Comparison<EnhancedPost> based on sorting method and reverse order flag
        public Comparison<EnhancedPost> GetPostSortStrategy()
        {
            Comparison<EnhancedPost> baseComparison = SortingMethodFactory.GetComparison(PostSortingMethod);

            if (ReverseOrder)
            {
                // If ReverseOrder is true, reverse the comparison
                return (firstPost, secondPost) => baseComparison(secondPost, firstPost);
            }

            return baseComparison;
        }
    }
}
