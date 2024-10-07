using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort
{
    public interface ISortingStrategy
    {
        Comparison<EnhancedPost> GetComparison();
    }
}