using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy
{
    public class ContainsPhotoFilterStrategy : IFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => !string.IsNullOrEmpty(i_Post.ImageUrl);
        }

        public override string ToString()
        {
            return "Filter: Contains Photos";
        }
    }
}