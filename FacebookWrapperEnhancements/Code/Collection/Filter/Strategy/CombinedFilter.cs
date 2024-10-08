using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class CombinedFilter : IFilterStrategy
    {
        public List<IFilterStrategy> SelectedFilters { get; set; } = new List<IFilterStrategy>();
        public bool MatchAllFilters { get; set; } = false;

        public Predicate<EnhancedPost> GetPredicate()
        {
            if (SelectedFilters == null || SelectedFilters.Count == 0)
            {
                return post => true;
            }

            List<Predicate<EnhancedPost>> activeFilters = SelectedFilters
                .Select(filter => filter.GetPredicate())
                .ToList();

            return post =>
                {
                    return MatchAllFilters
                               ? activeFilters.All(filter => filter(post))
                               : activeFilters.Any(filter => filter(post));
                };
        }

        public CombinedFilter DeepClone()
        {
            CombinedFilter clone = new CombinedFilter
                                       {
                                           MatchAllFilters = MatchAllFilters,
                                           SelectedFilters = new List<IFilterStrategy>(SelectedFilters)
                                       };

            return clone;
        }
    }
}