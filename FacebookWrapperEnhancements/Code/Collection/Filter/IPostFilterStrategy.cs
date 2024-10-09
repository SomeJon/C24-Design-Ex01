using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public interface IPostFilterStrategy
    {
        Predicate<EnhancedPost> GetPredicate();
        string ToString();
    }
}