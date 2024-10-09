using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostsByLikes : IPostSortingStrategy
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

        public override string ToString()
        {
            return "Sort by Number of Likes";
        }

        public override bool Equals(object obj)
        {
            return obj != null && this.GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
    }
}