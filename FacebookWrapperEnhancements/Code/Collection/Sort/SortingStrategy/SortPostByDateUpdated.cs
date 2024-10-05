using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByDateUpdated : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) => Nullable.Compare(i_SecondObject?.UpdateTime, i_FirstObject?.UpdateTime);
        }
    }
}
