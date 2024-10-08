using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostsByNumOfComments : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) =>
                {
                    if (i_FirstObject == null || i_SecondObject == null)
                    {
                        throw new ArgumentNullException(i_FirstObject == null ? nameof(i_FirstObject) : nameof(i_SecondObject));
                    }

                    return i_SecondObject.NumOfComments.CompareTo(i_FirstObject.NumOfComments);
                };
        }

        public override string ToString()
        {
            return "Sort by Number of Comments";
        }
    }
}