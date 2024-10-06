using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.Collection.Filter.Strategy;


namespace FacebookWrapperEnhancements.Code.Collection
{
    public class PagedCollection<T> : IEnumerable<T> where T : DynamicWrapper, new()
    {
        public Predicate<T> FilterStrategy { get; set; }
        public Comparison<T> SortStrategy { get; set; }
        public List<FacebookObjectCollectionWithPaging<T>> CollectionPages { get; }

        public List<T> CollectionData
        {
            get
            {
                List<T> toBeSorted = new List<T>(this);

                if(SortStrategy != null)
                {
                    toBeSorted.Sort(SortStrategy);
                }

                return toBeSorted;
            }
        }

        public string ParentId { get; }
        

        public PagedCollection(FacebookObjectCollectionWithPaging<T> i_TheCollection, string i_ParentId)
        {
            CollectionPages = new List<FacebookObjectCollectionWithPaging<T>> { i_TheCollection };
            ParentId = i_ParentId;
        }

        public void ResetCollection()
        {
            Paging paging = CollectionPages.First().PagingData;

            FacebookObjectCollectionWithPaging<T> newPage = FacebookServicesEnhancements
                .GetCollection<T>(paging.Connection,
                    ParentId, paging.Fields, paging.QueryParams);

            CollectionPages.Clear();
            CollectionPages.Add(newPage);
        }

        public bool FetchNewPage()
        {
            bool successfulLoad = false;
            FacebookObjectCollectionWithPaging<T> lastPage = CollectionPages.LastOrDefault();
            IHasPaging newPage = lastPage?.FetchNextPage(ParentId);
            
            if(newPage != null)
            {
                CollectionPages.Add(newPage as FacebookObjectCollectionWithPaging<T>);
                successfulLoad = true;
            }

            return successfulLoad;
        }

        public void FetchAllPages()
        {
            while(FetchNewPage())
            {
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(FacebookObjectCollectionWithPaging<T> page in CollectionPages)
            {
                foreach(T facebookObject in page)
                {
                    bool passedRequirement = FilterStrategy == null || FilterStrategy.Invoke(facebookObject);

                    if (passedRequirement)
                    {
                        yield return facebookObject;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void TryToGetAllInDates(DateTime i_Until, DateTime i_Since)
        {
            Paging paging = CollectionPages.First().PagingData;
            Dictionary<string, string> keyValuePairs =
                new Dictionary<string, string> (paging.QueryParams)
                    {
                        { "until", FilterData.ToUnixTimestamp(i_Until).ToString() },
                        { "since", FilterData.ToUnixTimestamp(i_Since).ToString() },
                    };

            FacebookObjectCollectionWithPaging<T> newPage = FacebookServicesEnhancements
                .GetCollection<T>(paging.Connection,
                ParentId, paging.Fields, keyValuePairs);

            CollectionPages.Clear();
            CollectionPages.Add(newPage);

            while (FetchNewPage())
            {
            }
        }
    }
}
