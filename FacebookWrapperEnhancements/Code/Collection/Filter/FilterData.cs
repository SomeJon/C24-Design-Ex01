using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy;
using FacebookWrapperEnhancements.Code.EnhancedObjects;


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
        public bool ReverseOrder { get; set; } = false;
        public bool MatchAllFilters
        {
            get => FilterStrategy.MatchAllFilters;
            set => FilterStrategy.MatchAllFilters = value;
        }
        public bool FilterByDate { get; set; } = false;
        public CombinedFilter FilterStrategy { get; set; } = new CombinedFilter();
        public ISortingStrategy SortingStrategy { get; set; } = new SortPostsByDatePublished();


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
                                       ReverseOrder = this.ReverseOrder,
                                       MatchAllFilters = this.MatchAllFilters,
                                       FilterStrategy = this.FilterStrategy.DeepClone(),
                                       SortingStrategy = this.SortingStrategy,
            };

            return clone;
        }

        public Predicate<EnhancedPost> GetPostFilterStrategy()
        {
            return FilterStrategy.GetPredicate();
        }

        public Comparison<EnhancedPost> GetPostSortStrategy()
        {
            Comparison<EnhancedPost> baseComparison = SortingStrategy.GetComparison();

            if (ReverseOrder)
            {
                baseComparison = (firstPost, secondPost) => SortingStrategy.GetComparison()(secondPost, firstPost);
            }

            return baseComparison;
        }
    }
}
