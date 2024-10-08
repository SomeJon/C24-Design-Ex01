using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;
using Facebook;
using System.Dynamic;
using FacebookWrapperEnhancements.Code.Collection;
using FacebookWrapperEnhancements.Code.EnhancedObjects;
using FetchHandler.Fetch;
using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FacebookWrapperEnhancements.Code
{
    public class FacebookServicesEnhancements
    {
        public static string AccessToken { get; set; }

        public static FacebookObjectCollectionWithPaging<T> RetrieveCollection<T>(
            string i_Connection,
            ref FacebookObjectCollectionWithPaging<T> io_TheCollection,
            string i_UserId,
            string i_Fields = "",
            Dictionary<string, string> i_KeyValueParametersPairs = null,
            eLoadOptions i_LoadOptions = eLoadOptions.Full,
            int? i_Limit = null)
            where T : DynamicWrapper, new()
        {
            if (io_TheCollection == null)
            {
                io_TheCollection = GetCollection<T>(i_Connection, i_UserId, i_Fields, 
                    i_KeyValueParametersPairs, i_Limit ?? FacebookService.s_CollectionLimit, 
                    i_LoadOptions);
            }

            return io_TheCollection;
        }

        public static FacebookObjectCollectionWithPaging<T> GetCollection<T>(
            string i_Connection,
            string i_UserId,
            string i_Fields = "",
            Dictionary<string, string> i_KeyValueParametersPairs = null,
            int? i_Limit = null,
            DynamicWrapper.eLoadOptions i_LoadOptions = DynamicWrapper.eLoadOptions.Full)
            where T : DynamicWrapper, new()
        {
            Fetcher fetchObject = new Fetcher(new UserFetchData(i_UserId, AccessToken));
            dynamic dynamicData = fetchObject.Fetch(i_Fields, i_Connection, i_KeyValueParametersPairs, i_Limit);
            return CreateCollection<T>(dynamicData, i_LoadOptions);
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
                T dynamicWrapper = new T();
                foreach (dynamic item in dynamicData)
                {
                    T val = null;

                    dynamicWrapper.WrapOrGet(ref val, item, i_LoadOptions);
                    collection.Add(val);
                }

                if (dynamicPagingData != null)
                {
                    Paging pagingData = null;

                    collection.PagingData = dynamicWrapper.WrapOrGet(ref pagingData, dynamicPagingData, i_LoadOptions);
                }
            }
            else
            {
                collection = new FacebookObjectCollectionWithPaging<T>();
            }
            
            return collection;
        }

        public static EnhancedUser FetchLoggedInUser(LoginResult i_LoginResult)
        {
            AccessToken = i_LoginResult.AccessToken;
            FacebookClient facebookClient = new FacebookClient(AccessToken);
            dynamic val = new ExpandoObject();
            val.fields = EnhancedUser.sr_FieldsToLoad[DynamicWrapper.eLoadOptions.Full];
            dynamic val2 = facebookClient.Get(string.Format("/{0}", "me"), val);
            EnhancedUser user = new EnhancedUser();
            EnhancedUser user2 = null;
            user.WrapOrGet(ref user2, val2, eLoadOptions.Full);

            return user2;
        }
    }
}
