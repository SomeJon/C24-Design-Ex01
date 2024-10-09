using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy
{
    public class CombinedFilter : IPostFilterStrategy
    {
        public List<IPostFilterStrategy> SelectedFilters { get; set; } = new List<IPostFilterStrategy>();
        public bool MatchAllFilters { get; set; } = false;

        public Predicate<EnhancedPost> GetPredicate()
        {
            if (SelectedFilters == null || SelectedFilters.Count == 0)
            {
                return i_Post => true;
            }

            List<Predicate<EnhancedPost>> activeFilters = SelectedFilters
                .Select(i_Filter => i_Filter.GetPredicate())
                .ToList();

            return i_Post =>
                {
                    return MatchAllFilters
                               ? activeFilters.All(i_Filter => i_Filter(i_Post))
                               : activeFilters.Any(i_Filter => i_Filter(i_Post));
                };
        }

        public CombinedFilter DeepClone()
        {
            CombinedFilter clone = new CombinedFilter
                                       {
                                           MatchAllFilters = MatchAllFilters,
                                           SelectedFilters = new List<IPostFilterStrategy>(SelectedFilters)
                                       };

            return clone;
        }
    }
}