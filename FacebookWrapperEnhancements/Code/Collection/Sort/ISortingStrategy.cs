using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Sort
{
    public interface ISortingStrategy
    {
        Comparison<EnhancedPost> GetComparison();
    }
}