using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort
{
    public interface IPostSortingStrategy
    {
        Comparison<EnhancedPost> GetComparison();
    }
}