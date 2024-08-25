using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Web.Script.Serialization;
using System.Threading.Tasks;


namespace FacebookPages.Code.Fetch
{
    public class FetchHandler
    {
        public string UserId { get; }
        public string AccessToken { get; }


        public FetchHandler(string i_UserId, string i_AccessToken)
        {
            UserId = i_UserId;
            AccessToken = i_AccessToken;
        }

        public T FetchToObj<T>(string i_Fields)
        {
            FacebookClient facebookClient = new FacebookClient(AccessToken);
            dynamic fieldsValue = new ExpandoObject();

            fieldsValue.fields = i_Fields;

            dynamic loadObject = facebookClient.Get($"/{UserId}", fieldsValue);
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
