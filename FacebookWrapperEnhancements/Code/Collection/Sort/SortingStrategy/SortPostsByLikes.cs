using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostsByLikes : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) =>
                {
                    if (i_FirstObject == null || i_SecondObject == null)
                    {
                        throw new ArgumentNullException(i_FirstObject == null ? nameof(i_FirstObject) : nameof(i_SecondObject));
                    }

                    return i_SecondObject.NumOfLikes.CompareTo(i_FirstObject.NumOfLikes);
                };
        }
    }
}