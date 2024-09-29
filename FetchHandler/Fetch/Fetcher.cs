using Facebook;
using System;
using System.Collections.Generic;
using System.Dynamic;
using FacebookPages.Code.Pages.Data;
using FacebookWrapper;
using System.Windows.Forms.VisualStyles;


namespace FetchHandler.Fetch
{
    public class Fetcher
    {
        public UserFetchData UserFetchData { get; }

        public Fetcher(UserFetchData i_FetchData)
        {
            UserFetchData = i_FetchData;
        }

        public object Fetch(string i_Fields, string i_Path = null, 
                            Dictionary<string, string> i_ParametersToAdd = null,
                            int? i_Limit = null, Type i_Type = null)
        {
            FacebookClient facebookClient = new FacebookClient(UserFetchData.AccessToken);
            dynamic parametersKeyValueRequest = new ExpandoObject();
            string path = $"/{UserFetchData.UserId}";

            if (!string.IsNullOrEmpty(i_Path))
            {
                path += "/" + i_Path;
            }

            if (i_ParametersToAdd != null)
            {
                parametersKeyValueRequest = toExpando(i_ParametersToAdd);
            }
            parametersKeyValueRequest.fields = i_Fields;
            parametersKeyValueRequest.limit = i_Limit ?? FacebookService.s_CollectionLimit;

            dynamic loadObject = facebookClient.Get(path, parametersKeyValueRequest, i_Type);

            return loadObject;
        }

        private static ExpandoObject toExpando(Dictionary<string, string> i_KeyValuePairs)
        {
            ExpandoObject expando = new ExpandoObject();
            IDictionary<string, object> expandoDict = expando;

            foreach (KeyValuePair<string, string> kvp in i_KeyValuePairs)
            {
                expandoDict[kvp.Key] = kvp.Value;
            }

            return expando;
        }
    }
}
