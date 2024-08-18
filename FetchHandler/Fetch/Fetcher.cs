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

        public T FetchToObj<T>(string i_Fields)
        {
            FacebookClient facebookClient = new FacebookClient(UserFetchData.AccessToekn);
            dynamic fieldsValue = new ExpandoObject();

            fieldsValue.fields = i_Fields;

            dynamic loadObject = facebookClient.Get($"/{UserFetchData.UserId}", fieldsValue);
            //JsonObject keyValuePairs = loadObject;
            return ConvertJsonTo<T>(loadObject.ToString());
        }

        public static T ConvertJsonTo<T>(string i_Json)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(i_Json);
        }
    }
}
