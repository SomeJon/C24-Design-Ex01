using System;
using System.Collections.Generic;

namespace FacebookPages.Code.Pages.Data.Post.Sort
{
    public static class SortingMethod
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

        public static IComparer<UpdatedPostData> GetComparer(eSortingMethod iSortingMethod)
        {
            switch (iSortingMethod)
            {
                case eSortingMethod.ByDatePublished:
                    return sortByDatePublished();
                case eSortingMethod.ByDateUpdated:
                    return sortByDateUpdated();
                case eSortingMethod.ByWriter:
                    return sortByWriter();
                case eSortingMethod.ByPostType:
                    return sortByPostType();
                case eSortingMethod.ByLikes:
                    return sortByLikes();
                case eSortingMethod.ByNumOfComments:
                    return sortByNumOfComments();
                default:
                    throw new ArgumentException("Invalid sorting method", nameof(iSortingMethod));
            }
        }

        private static IComparer<UpdatedPostData> sortByDatePublished()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(y.CreatedTime, x.CreatedTime);
            });
        }

        private static IComparer<UpdatedPostData> sortByDateUpdated()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(y.UpdateTime, x.UpdateTime);
            });
        }

        private static IComparer<UpdatedPostData> sortByWriter()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            });
        }

        private static IComparer<UpdatedPostData> sortByPostType()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                string xType = x.Type?.ToString() ?? string.Empty;
                string yType = y.Type?.ToString() ?? string.Empty;
                return string.Compare(xType, yType, StringComparison.OrdinalIgnoreCase);
            });
        }

        private static IComparer<UpdatedPostData> sortByLikes()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return y.NumOfLikes.CompareTo(x.NumOfLikes);
            });
        }

        private static IComparer<UpdatedPostData> sortByNumOfComments()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return y.NumOfComments.CompareTo(x.NumOfComments);
            });
        }
    }
}
