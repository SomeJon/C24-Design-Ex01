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
                    throw new ArgumentException("Invalid sorting method", nameof(i_SortingMethod));
            }
        }

        private static IComparer<UpdatedPostData> sortByDatePublished()
        {
            return Comparer<UpdatedPostData>
                .Create((x, y) 
                    => 
                    Nullable
                        .Compare(y.CreatedTime, x.CreatedTime));
        }

        private static IComparer<UpdatedPostData> sortByDateUpdated()
        {
            return Comparer<UpdatedPostData>
                .Create((x, y)
                    => 
                    Nullable
                        .Compare(y.UpdateTime, x.UpdateTime));
        }

        private static IComparer<UpdatedPostData> sortByWriter()
        {
            return Comparer<UpdatedPostData>
                .Create((x, y) 
                    => 
                    string
                        .Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase));
        }

        private static IComparer<UpdatedPostData> sortByPostType() =>
            Comparer<UpdatedPostData>
                .Create((x, y) 
                    => 
                    {
                        string xType = x.Type?.ToString() ?? string.Empty;
                        string yType = y.Type?.ToString() ?? string.Empty;
                        return string.Compare(xType, yType, StringComparison.OrdinalIgnoreCase);
                    });

        private static IComparer<UpdatedPostData> sortByLikes()
        {
            return Comparer<UpdatedPostData>
                .Create((x, y) 
                    => 
                    y.NumOfLikes.CompareTo(x.NumOfLikes));
        }

        private static IComparer<UpdatedPostData> sortByNumOfComments()
        {
            return Comparer<UpdatedPostData>
                .Create((x, y) 
                    =>
                    y.NumOfComments.CompareTo(x.NumOfComments));
        }
    }
}
