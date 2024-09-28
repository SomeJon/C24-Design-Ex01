using FacebookPages.Code.Pages.Data.Post.Filter;
using FacebookPages.Code.Pages.Data.Post.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostsWithPaging<T> : PageData where T : UpdatedPostData
    {
        private Paging m_Paging;
        private DataFilter m_DataFilter;
        private List<T> m_Posts = new List<T>();
        public bool HasNext { get; private set; } = true;
        public DataFilter FilterData 
        {
            get => m_DataFilter;
            set
            {
                bool rematchNeeded = false;

                if(m_DataFilter?.UserSource != value.UserSource && PageFetcherObject != null)
                {
                    PageFetcherObject.UserFetchData.UserId = value.UserSource.Id;
                    rematchNeeded = true;
                }

                value.Conditions.TryGetValue
                    (FilterMethod.eFilterCondition.DateFilter, out bool dateRematchNeeded);
                if (dateRematchNeeded)
                {
                    tryToGetAllInDates(value.MaxDate, value.MinDate);
                    rematchNeeded = !dateRematchNeeded;
                }

                if (rematchNeeded)
                {
                    TryFetchAndLoadPageData();
                }

                m_DataFilter = value;
            }
        }
        public List<T> Posts
        {
            get
            {
                FilterMethod.MatchAllFilters = FilterData.MatchAllFilters;
                Func<UpdatedPostData, bool> combinedFilter = FilterMethod.GetCombinedFilter
                    (FilterData.Conditions, FilterData.TextContainsString);
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
            get => WrapOrGet<Paging>(ref m_Paging, m_DynamicData.paging, eLoadOptions.Full);

            set => m_Paging = value;
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

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => sr_FieldsToLoad;

        protected override void InitializeAfterSet()
        {
            AddToCollection(m_DynamicData.data, m_Posts);
        }

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            m_Posts?.Clear();
            m_Paging = null;
            HasNext = true;
        }

        public void SwitchConnection(string i_Connection)
        {
            if (!string.Equals(i_Connection, Connection))
            {
                Connection = i_Connection;
                TryFetchAndLoadPageData();
            }
        }

        public bool TryToAddNextPage()
        {
            bool success = false;
            PostsWithPaging<T> nextPosts = new PostsWithPaging<T>();

            if (HasNext)
            {
                nextPosts.Connection = Connection;
                nextPosts.PageFetcherObject = PageFetcherObject;
                Dictionary<string, string> keyValuePairs = 
                    Paging.GetKeyValueParametersFromUrl(
                        this.Paging.NextPageUrl, 
                        new List<string> { "until", "since", "pretty", "__paging_token" }
                        );

                nextPosts.TryFetchAndLoadPageData(null, keyValuePairs);

                if (nextPosts.m_Posts.Count > 0)
                {
                    m_Posts.AddRange(nextPosts.m_Posts);
                    Paging = nextPosts.Paging;
                    success = true;
                }
                else
                {
                    HasNext = false;
                }
            }

            return success;
        }

        private void tryToGetAllInDates(DateTime i_Until, DateTime i_Since)
        {
            Dictionary<string, string> keyValuePairs = 
                new Dictionary<string, string>
                    {
                        { "until", DataFilter.ToUnixTimestamp(i_Until).ToString() },
                        { "since", DataFilter.ToUnixTimestamp(i_Since).ToString() }
                    };

            this.FetchNext = true;
            this.TryFetchAndLoadPageData(null, keyValuePairs);

            try
            {
                while (TryToAddNextPage());
            }
            catch (System.InvalidOperationException i_InvalidOperation)
            {
                MessageBox.Show(i_InvalidOperation.Message + " :: Plesae wait a little while and try again.", "Error");
            }
        }
    }
}
