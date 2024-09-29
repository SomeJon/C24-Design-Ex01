using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using System.Dynamic;
using FacebookWrapperEnhancements.Code.Collection;
using FetchHandler.Fetch;
using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FacebookWrapperEnhancements.Code
{
    public class FacebookServicesEnhancements
    {
        public static FacebookObjectCollectionWithPaging<T> GetCollection<T>(
            string i_Connection,
            Fetcher i_FetchObject,
            string i_Fields = "",
            int? i_Limit = null,
            DynamicWrapper.eLoadOptions i_LoadOptions = DynamicWrapper.eLoadOptions.Full,
            Dictionary<string, string> i_KeyValueParametersPairs = null)
            where T : DynamicWrapper, new()
        {
            dynamic dynamicData = i_FetchObject.Fetch(i_Fields, i_Connection, i_KeyValueParametersPairs, i_Limit);
            return FacebookServicesEnhancements.CreateCollection<T>(dynamicData, i_LoadOptions);
        }

        internal static FacebookObjectCollectionWithPaging<T> CreateCollection<T>(
            dynamic i_DynamicCollection,
            DynamicWrapper.eLoadOptions i_LoadOptions = DynamicWrapper.eLoadOptions.Full)
            where T : DynamicWrapper, new()
        {
            FacebookObjectCollectionWithPaging<T> collection = null;
            dynamic dynamicData = i_DynamicCollection.data;
            dynamic dynamicPagingData = i_DynamicCollection.paging;

            if (dynamicData != null)
            {
                collection = new FacebookObjectCollectionWithPaging<T>(dynamicData.Count);
                foreach (dynamic item in dynamicData)
                {
                    T val = new T();

                    val.WrapOrGet(ref val, item, i_LoadOptions);
                    collection.Add(val);
                }

                if (dynamicPagingData != null)
                {
                    Paging pagingData = collection.PagingData;

                    pagingData.WrapOrGet(ref pagingData, dynamicPagingData, i_LoadOptions);
                }
            }
            else
            {
                collection = new FacebookObjectCollectionWithPaging<T>();
            }
            
            return collection;
        }
    }
}
