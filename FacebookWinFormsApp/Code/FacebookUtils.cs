using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
using FacebookWrapper;

namespace FacebookClient.Code
{
    internal class FacebookUtils
    {
        public string UserId { get; }
        public string AccessToken { get; }


        public FacebookUtils(string i_UserId, string i_AccessToken) 
        { 
            UserId = i_UserId;
            AccessToken = i_AccessToken;
        }

        public Facebook.JsonObject Fetch(string i_Fields)
        {
            Facebook.FacebookClient facebookClient = new Facebook.FacebookClient(AccessToken);
            dynamic val = new ExpandoObject();

            val.fields = i_Fields;

            dynamic loadObject = facebookClient.Get($"/{UserId}", val);

            return loadObject;
        }
    }
}
