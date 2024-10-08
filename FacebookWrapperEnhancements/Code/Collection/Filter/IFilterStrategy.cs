using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter
{
    public interface IFilterStrategy
    {
        Predicate<EnhancedPost> GetPredicate();
        string ToString();
    }
}