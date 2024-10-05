using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByWriter : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) => string.Compare(i_SecondObject?.Name, i_FirstObject?.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}