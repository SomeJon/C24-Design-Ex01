using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using FacebookPages.Code.Pages.Data;


namespace FetchHandler.Fetch
{
    public class Fetcher
    {
        public UserFetchData UserFetchData { get; }


        public Fetcher(UserFetchData i_FetchData)
        {
            UserFetchData = i_FetchData;
        }

        public T FetchToObj<T>(string i_Fields, string i_Path = null)
        {
            FacebookClient facebookClient = new FacebookClient(UserFetchData.AccessToekn);
            dynamic fieldsValue = new ExpandoObject();
            string path = $"/{UserFetchData.UserId}";

            if (!string.IsNullOrEmpty(i_Path))
            {
                path += "/" + i_Path;
            }
            
            fieldsValue.fields = i_Fields;
            dynamic loadObject = facebookClient.Get(path, fieldsValue);

            return ConvertJsonTo<T>(loadObject.ToString());
        }

        private static T ConvertJsonTo<T>(string i_Json)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(i_Json);
        }

        public Object Fetch(string i_Fields, string i_Path = null)
        {
            FacebookClient facebookClient = new FacebookClient(UserFetchData.AccessToekn);
            dynamic fieldsValue = new ExpandoObject();
            string path = $"/{UserFetchData.UserId}";

            if (!string.IsNullOrEmpty(i_Path))
            {
                path += "/" + i_Path;
            }

            fieldsValue.fields = i_Fields;

            dynamic loadObject = facebookClient.Get(path, fieldsValue);

            return loadObject;
        }
    }
}
