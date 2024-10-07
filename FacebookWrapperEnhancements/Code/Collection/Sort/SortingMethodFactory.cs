using System;
using System.Collections.Generic;
using FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

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

        public static Dictionary<eSortingMethod, string> SortingOptions { get; } =
            new Dictionary<eSortingMethod, string>
                {
                    { eSortingMethod.ByDatePublished, "Sort by Date Published" },
                    { eSortingMethod.ByDateUpdated, "Sort by Date Updated" },
                    { eSortingMethod.ByWriter, "Sort by Writer" },
                    { eSortingMethod.ByPostType, "Sort by Post Type" },
                    { eSortingMethod.ByLikes, "Sort by Number of Likes" },
                    { eSortingMethod.ByNumOfComments, "Sort by Number of Comments" }
                };


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
