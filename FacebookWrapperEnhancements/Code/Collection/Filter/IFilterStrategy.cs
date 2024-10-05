using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public interface IFilterStrategy
    {
        Predicate<EnhancedPost> GetPredicate();
    }
}