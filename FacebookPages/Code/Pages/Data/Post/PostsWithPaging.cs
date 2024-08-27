using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostsWithPaging<T> : PageData where T : FacebookWrapper.ObjectModel.Post
    {
        private Paging m_Paging;
        public List<T> Posts { get; } = new List<T>();
        public Paging Paging
        {
            get
            {
                return WrapOrGet<Paging>(ref m_Paging, m_DynamicData.paging, eLoadOptions.Full);
            }
            set
            {
                m_Paging = value;
            }
        }

        public PostsWithPaging()
        {
            Connection = "posts";
        }

        private static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoad = new Dictionary<eLoadOptions, string>
        {
        {
            eLoadOptions.None,
            "id, message"
        },
        {
            eLoadOptions.Basic,
            "id," +
                "message,story," +
                "created_time," +
                "updated_time," +
                "place," +
                "full_picture," +
                "from{name,id}," +
                "reactions.limit(1000).summary(true)," +
                "comments.limit(1000).summary(true)," +
                "status_type," +
                "type"
        },
        {
            eLoadOptions.Full,
            "id," +
                "message,story," +
                "created_time," +
                "updated_time," +
                "place," +
                "full_picture," +
                "attachments," +
                "from{name,id}," +
                "to{id,name}," +
                "reactions.limit(1000).summary(true)," +
                "comments.limit(1000).summary(true)," +
                "status_type," +
                "type"
                
        },
        {
            eLoadOptions.FullWithConnections,
            "id," +
                "message,story," +
                "created_time," +
                "updated_time," +
                "place," +
                "full_picture," +
                "attachments," +
                "from{name,id}," +
                "to{id,name}," +
                "reactions.limit(1000).summary(true)," +
                "comments.limit(1000).summary(true)," +
                "status_type," +
                "type"
        }
        };

        protected Dictionary<eLoadOptions, string> CurrentFieldsToLoad = sr_FieldsToLoad; //allowing some modification for the future! its importent

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => CurrentFieldsToLoad;

        protected override void InitializeAfterSet()
        {
            AddToCollection(m_DynamicData.data, Posts);
        }

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            Posts?.Clear();
            m_Paging?.Clear();
        }

        public void SwitchConnection(string i_Connection)
        {
            if (!string.Equals(i_Connection, Connection))
            {
                ResetForReFetch();
                Connection = i_Connection;
                TryFetchAndLoadData();
            }
        }

        public void TryToAddNextPage()
        {
            Dictionary<string, string> keyValuePairs;
            PostsWithPaging<T> nextPosts = new PostsWithPaging<T>();


            nextPosts.Connection = Connection;
            nextPosts.PageFetcherObject = PageFetcherObject;
            keyValuePairs = Paging.GetKeyValueParamtersFromUrl(this.Paging.NextPageUrl, new List<string> { "until", "since", "pretty", "__paging_token" });
            
            nextPosts.TryFetchAndLoadData(null, keyValuePairs);
            Posts.AddRange(nextPosts.Posts);
            Paging = nextPosts.Paging;
        }
    }
}
