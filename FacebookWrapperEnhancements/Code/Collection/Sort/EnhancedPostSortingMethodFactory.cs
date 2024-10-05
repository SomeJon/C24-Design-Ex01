using System;
using FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Sort
{
    public static class SortingMethodFactory
    {
        public enum eSortingMethod
        {
            ByDatePublished,
            ByDateUpdated,
            ByWriter,
            ByPostType,
            ByLikes,
            ByNumOfComments,
        }

        public static Comparison<EnhancedPost> GetComparison(eSortingMethod i_SortingMethod)
        {
            switch (i_SortingMethod)
            {
                case eSortingMethod.ByDatePublished:
                    return new SortPostsByDatePublished().GetComparison();
                case eSortingMethod.ByDateUpdated:
                    return new SortPostByDateUpdated().GetComparison();
                case eSortingMethod.ByWriter:
                    return new SortPostByWriter().GetComparison();
                case eSortingMethod.ByPostType:
                    return new SortPostByType().GetComparison();
                case eSortingMethod.ByLikes:
                    return new SortPostsByLikes().GetComparison();
                case eSortingMethod.ByNumOfComments:
                    return new SortPostsByNumOfComments().GetComparison();
                default:
                    throw new ArgumentException("Invalid sorting method", nameof(i_SortingMethod));
            }
        }
    }
}
