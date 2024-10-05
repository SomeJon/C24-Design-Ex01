using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;

namespace FacebookWrapperEnhancements.Code.Collection
{
    public class FacebookObjectCollectionWithPaging<T> 
        : IEnumerable<T>, IHasPaging where T : DynamicWrapper, new()
    {
        private readonly FacebookObjectCollection<T> r_Collection;
        public Paging PagingData { get; internal set; }

        public FacebookObjectCollectionWithPaging()
        {
            r_Collection = new FacebookObjectCollection<T>();
        }

        public FacebookObjectCollectionWithPaging(int i_Capacity)
        {
            r_Collection = new FacebookObjectCollection<T>(i_Capacity);
        }

        public T Find(Predicate<T> i_Predicate)
        {
            return r_Collection.Find(i_Predicate);
        }

        public int Count => r_Collection.Count;

        public void Add(T i_Item)
        {
            r_Collection.Add(i_Item);
        }

        public bool Remove(T i_Item)
        {
            return r_Collection.Remove(i_Item);
        }

        public void Clear()
        {
            r_Collection.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return r_Collection.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IHasPaging FetchNextPage(string i_Id)
        {
            FacebookObjectCollectionWithPaging<T> newPage = FacebookServicesEnhancements.GetCollection<T>(PagingData.Connection,
                i_Id, PagingData.Fields, PagingData.QueryParams);

            if(newPage.Count == 0)
            {
                newPage = null;
            }

            return newPage;
        }
    }

}
