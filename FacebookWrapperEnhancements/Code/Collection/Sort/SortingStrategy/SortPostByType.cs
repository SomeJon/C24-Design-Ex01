using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByType : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) =>
                {
                    string firstObjectType = i_FirstObject?.Type?.ToString() ?? string.Empty;
                    string secondObjectType = i_SecondObject?.Type?.ToString() ?? string.Empty;
                    return string.Compare(secondObjectType, firstObjectType, StringComparison.OrdinalIgnoreCase);
                };
        }
    }
}