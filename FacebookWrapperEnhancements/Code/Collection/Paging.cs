using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookWrapperEnhancements.Code.Collection
{
    public class Paging : FacebookObject
    {
        public string PreviousPageUrl
        {
            get => (string)m_DynamicData.previous;

            set => m_DynamicData.previous = value;
        }
        public string NextPageUrl
        {
            get => (string)m_DynamicData.next;

            set => m_DynamicData.next = value;
        }
        public int PageNumber { get; internal set; }

        public static Dictionary<string, string> GetKeyValueParametersFromUrl(string i_Url, List<string> i_ParameterNames)
        {
            Dictionary<string, string> queryParams = ParseQueryString(i_Url);
            Dictionary<string, string> returningPairs = null;

            foreach (string parameterName in i_ParameterNames)
            {
                if (queryParams.TryGetValue(parameterName, out string parameterValue))
                {
                    if(returningPairs == null)
                    {
                        returningPairs = new Dictionary<string, string>();
                    }

                    returningPairs.Add(parameterName, parameterValue);
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
