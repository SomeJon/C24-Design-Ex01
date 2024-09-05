using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class Paging : PageData
    {
        public string PreviousPageUrl
        {
            get
            {
                return (string)m_DynamicData.previous;
            }

            set
            {
                m_DynamicData.previous = value;
            }
        }
        public string NextPageUrl
        {
            get
            {
                return (string)m_DynamicData.next;
            }

            set
            {
                m_DynamicData.next = value;
            }
        }

        public static Dictionary<string, string> GetKeyValueParamtersFromUrl(string i_Url, List<string> i_ParamterNames)
        {
            Dictionary<string, string> queryParams = ParseQueryString(i_Url);
            Dictionary<string, string> returningPairs = null;

            foreach (string paramterName in i_ParamterNames)
            {
                if (queryParams.TryGetValue(paramterName, out string ParamterValue))
                {
                    if(returningPairs == null)
                    {
                        returningPairs = new Dictionary<string, string>();
                    }

                    returningPairs.Add(paramterName, ParamterValue);
                }
            }

            return returningPairs;
        }

        public void Clear()
        {
            PreviousPageUrl = string.Empty;
            NextPageUrl = string.Empty;
            base.ResetForReFetch();
        }

        public static Dictionary<string, string> ParseQueryString(string i_Url)
        {
            Uri uri = new Uri(i_Url);
            Dictionary<string, string> queryParams = new Dictionary<string, string>();

            string[] querySegments = uri.Query.TrimStart('?').Split('&');

            foreach (string segment in querySegments)
            {
                string[] keyValue = segment.Split('=');
                if (keyValue.Length == 2)
                {
                    string key = Uri.UnescapeDataString(keyValue[0]);
                    string value = Uri.UnescapeDataString(keyValue[1]);

                    queryParams[key] = value;
                }
            }

            return queryParams;
        }
    }
}
