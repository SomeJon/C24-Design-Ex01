using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class DefaultFilterStrategy : IFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => true; // Default strategy does nothing, always returns true
        }
    }
}