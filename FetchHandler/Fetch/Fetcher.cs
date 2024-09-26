using Facebook;
using System;
using System.Collections.Generic;
using System.Dynamic;
using FacebookPages.Code.Pages.Data;


namespace FetchHandler.Fetch
{
    public class Fetcher
    {
        public UserFetchData UserFetchData { get; }

        public Fetcher(UserFetchData iFetchData)
        {
            UserFetchData = iFetchData;
        }

        public Object Fetch(string iFields, string iPath = null, Dictionary<string, string> iParamtersToAdd = null, Type iType = null)
        {
            FacebookClient facebookClient = new FacebookClient(UserFetchData.AccessToekn);
            dynamic paramtersKeyValueRequest = new ExpandoObject();
            string path = $"/{UserFetchData.UserId}";

            if (!string.IsNullOrEmpty(iPath))
            {
                path += "/" + iPath;
            }

            if (iParamtersToAdd != null)
            {
                paramtersKeyValueRequest = toExpando(iParamtersToAdd);
            }
            paramtersKeyValueRequest.fields = iFields;


            dynamic loadObject = facebookClient.Get(path, paramtersKeyValueRequest, iType);

            return loadObject;
        }

        private ExpandoObject toExpando(Dictionary<string, string> iKeyValuePairs)
        {
            var expando = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>)expando;

            foreach (var kvp in iKeyValuePairs)
            {
                expandoDict[kvp.Key] = kvp.Value;
            }

            return expando;
        }
    }
}
