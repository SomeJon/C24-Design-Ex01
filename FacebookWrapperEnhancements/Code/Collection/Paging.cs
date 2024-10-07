using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookWrapperEnhancements.Code.Collection
{
    public class Paging : FacebookObject
    {
        private string m_Fields;
        private string m_Connection;
        private string m_UserId;
        private Dictionary<string, string> m_QueryParams;
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
        public string Fields => getOrParse(ref m_Fields);
        public string Connection => getOrParse(ref m_Connection);
        public string UserId => getOrParse(ref m_UserId);
        public Dictionary<string, string> QueryParams => getOrParse(ref m_QueryParams);

        private T getOrParse<T>(ref T io_Field)
        {
            if (io_Field == null)
            {
                parseFacebookNextUrl();
            }

            return io_Field;
        }

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

        private void parseFacebookNextUrl()
        {
            Uri uri = new Uri(NextPageUrl);
            string[] pathSegments = uri.AbsolutePath.TrimStart('/').Split('/');

            m_UserId = pathSegments.Length > 1 ? pathSegments[1] : string.Empty;
            m_Connection = pathSegments.Length > 2 ? pathSegments[2] : string.Empty;

            m_QueryParams = ParseQueryString(NextPageUrl);
            m_QueryParams.TryGetValue("fields", out m_Fields);
            m_QueryParams.Remove("fields");
        }
    }
}
