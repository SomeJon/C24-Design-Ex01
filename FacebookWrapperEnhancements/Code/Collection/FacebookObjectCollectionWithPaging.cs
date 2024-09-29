using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWrapperEnhancements.Code.Collection
{
    public class FacebookObjectCollectionWithPaging<T> : IEnumerable<T>, IHasPaging where T : DynamicWrapper, new()
    {
        private FacebookObjectCollection<T> m_Collection;

        public FacebookObjectCollectionWithPaging()
        {
            m_Collection = new FacebookObjectCollection<T>();
        }

        public FacebookObjectCollectionWithPaging(int i_Capacity)
        {
            m_Collection = new FacebookObjectCollection<T>(i_Capacity);
        }

        public Paging PagingData { get; internal set; } = new Paging();

        public T Find(Predicate<T> i_Predicate)
        {
            return m_Collection.Find(i_Predicate);
        }

        public int Count => m_Collection.Count;

        public void Add(T i_Item)
        {
            m_Collection.Add(i_Item);
        }

        public bool Remove(T i_Item)
        {
            return m_Collection.Remove(i_Item);
        }

        public void Clear()
        {
            m_Collection.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return m_Collection.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
