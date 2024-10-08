using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection.Filter.Strategy;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using static FacebookWrapperEnhancements.Code.Collection.Sort.SortingMethodFactory;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public class FilterData
    {
        public EnhancedUser UserSource { get; set; }
        public List<User> AvailableUsersToSelect { get; set; } = new List<User>();
        public DateTime MinDate { get; set; } =
            new System.DateTime
                (1900, 1, 1, 0, 0, 0, 0);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public SortingMethodFactory.eSortingMethod PostSortingMethod { get; set; } =
            SortingMethodFactory.eSortingMethod.ByDatePublished;
        public bool ReverseOrder { get; set; } = false;
        public bool MatchAllFilters
        {
            get => FilterStrategy.MatchAllFilters;
            set => FilterStrategy.MatchAllFilters = value;
        }
        public bool FilterByDate { get; set; } = false;
        public CombinedFilter FilterStrategy { get; set; } = new CombinedFilter();


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
                                       MinDate = this.MinDate,
                                       MaxDate = this.MaxDate,
                                       PostSortingMethod = this.PostSortingMethod,
                                       ReverseOrder = this.ReverseOrder,
                                       MatchAllFilters = this.MatchAllFilters,
                                       FilterStrategy = FilterStrategy.DeepClone(),
                                   };

            return clone;
        }

        public Predicate<EnhancedPost> GetPostFilterStrategy()
        {
            return FilterStrategy.GetPredicate();
        }

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
