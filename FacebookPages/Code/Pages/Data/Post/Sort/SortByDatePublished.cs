using System;
using System.Collections.Generic;

namespace FacebookPages.Code.Pages.Data.Post.Sort
{
    public static class SortingMethods
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

        public static IComparer<UpdatedPostData> GetComparer(eSortingMethod sortingMethod)
        {
            switch (sortingMethod)
            {
                case eSortingMethod.ByDatePublished:
                    return SortByDatePublished();
                case eSortingMethod.ByDateUpdated:
                    return SortByDateUpdated();
                case eSortingMethod.ByWriter:
                    return SortByWriter();
                case eSortingMethod.ByPostType:
                    return SortByPostType();
                case eSortingMethod.ByLikes:
                    return SortByLikes();
                case eSortingMethod.ByNumOfComments:
                    return SortByNumOfComments();
                default:
                    throw new ArgumentException("Invalid sorting method", nameof(sortingMethod));
            }
        }

        public static IComparer<UpdatedPostData> SortByDatePublished()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(x.CreatedTime, y.CreatedTime);
            });
        }

        public static IComparer<UpdatedPostData> SortByDateUpdated()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(x.UpdateTime, y.UpdateTime);
            });
        }

        public static IComparer<UpdatedPostData> SortByWriter()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            });
        }

        public static IComparer<UpdatedPostData> SortByPostType()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                string xType = x.Type?.ToString() ?? string.Empty;
                string yType = y.Type?.ToString() ?? string.Empty;
                return string.Compare(xType, yType, StringComparison.OrdinalIgnoreCase);
            });
        }

        public static IComparer<UpdatedPostData> SortByLikes()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return x.NumOfLikes.CompareTo(y.NumOfLikes);
            });
        }

        public static IComparer<UpdatedPostData> SortByNumOfComments()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return x.NumOfComments.CompareTo(y.NumOfComments);
            });
        }
    }
}
