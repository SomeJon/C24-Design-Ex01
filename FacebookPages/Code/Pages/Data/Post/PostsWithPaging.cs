using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostsWithPaging : PageData
    {
        private Paging m_Paging;
        public List<PostData> Data { get; } = new List<PostData>();
        public Paging Paging
        {
            get
            {
                return WrapOrGet<Paging>(ref m_Paging, m_DynamicData.paging, eLoadOptions.Full);
            }
        }

        private static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoad = new Dictionary<eLoadOptions, string>
        {
        {
            eLoadOptions.None,
            "id, name"
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
            AddToCollection(m_DynamicData.data, Data);
        }
    }
}
