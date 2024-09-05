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

        public static IComparer<UpdatedPostData> GetComparer(eSortingMethod i_SortingMethod)
        {
            switch (i_SortingMethod)
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
                    throw new ArgumentException("Invalid sorting method", nameof(i_SortingMethod));
            }
        }

        private static IComparer<UpdatedPostData> SortByDatePublished()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(y.CreatedTime, x.CreatedTime);
            });
        }

        private static IComparer<UpdatedPostData> SortByDateUpdated()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return Nullable.Compare(y.UpdateTime, x.UpdateTime);
            });
        }

        private static IComparer<UpdatedPostData> SortByWriter()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            });
        }

        private static IComparer<UpdatedPostData> SortByPostType()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                string xType = x.Type?.ToString() ?? string.Empty;
                string yType = y.Type?.ToString() ?? string.Empty;
                return string.Compare(xType, yType, StringComparison.OrdinalIgnoreCase);
            });
        }

        private static IComparer<UpdatedPostData> SortByLikes()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return y.NumOfLikes.CompareTo(x.NumOfLikes);
            });
        }

        private static IComparer<UpdatedPostData> SortByNumOfComments()
        {
            return Comparer<UpdatedPostData>.Create((x, y) =>
            {
                return y.NumOfComments.CompareTo(x.NumOfComments);
            });
        }
    }
}
