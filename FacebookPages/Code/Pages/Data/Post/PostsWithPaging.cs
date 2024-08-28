using FacebookPages.Code.Pages.Data.Post.Filter;
using FacebookPages.Code.Pages.Data.Post.Sort;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostsWithPaging<T> : PageData where T : UpdatedPostData
    {
        private Paging m_Paging;
        private List<T> m_Posts = new List<T>();
        public FilterData FilterData { get; set; }
        public List<T> Posts
        {
            get
            {
                Func<UpdatedPostData, bool> combinedFilter = FilterMethod.GetCombinedFilter(FilterData.Conditions);
                List<T> filteredPosts = new List<T>(m_Posts);

                if (FilterData != null)
                {
                    filteredPosts = m_Posts.Where(post => combinedFilter(post)).ToList();

                    filteredPosts.Sort(SortingMethod.GetComparer(FilterData.SortingMethod));

                    if (FilterData.ReverseOrder)
                    {
                        filteredPosts.Reverse();
                    }
                }

                return filteredPosts;
            }
        }
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

        protected Dictionary<eLoadOptions, string> CurrentFieldsToLoad = sr_FieldsToLoad;

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => CurrentFieldsToLoad;

        protected override void InitializeAfterSet()
        {
            AddToCollection(m_DynamicData.data, m_Posts);
        }

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            m_Posts?.Clear();
            m_Paging = null;
        }

        public void SwitchConnection(string i_Connection)
        {
            if (!string.Equals(i_Connection, Connection))
            {
                Connection = i_Connection;
                TryFetchAndLoadPageData();
            }
        }

        public void TryToAddNextPage()
        {
            Dictionary<string, string> keyValuePairs;
            PostsWithPaging<T> nextPosts = new PostsWithPaging<T>();


            nextPosts.Connection = Connection;
            nextPosts.PageFetcherObject = PageFetcherObject;
            keyValuePairs = Paging.GetKeyValueParamtersFromUrl(this.Paging.NextPageUrl, new List<string> { "until", "since", "pretty", "__paging_token" });

            nextPosts.TryFetchAndLoadPageData(null, keyValuePairs);

            if (nextPosts.m_Posts.Count > 0)
            {
                m_Posts.AddRange(nextPosts.m_Posts);
                Paging = nextPosts.Paging;
            }
            else
            {
                MessageBox.Show("No more Posts to retrieve", "Posts request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
