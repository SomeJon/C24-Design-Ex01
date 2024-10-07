using System;
using System.Collections.Generic;

namespace FacebookWrapperEnhancements.Code.EnhancedObjects
{
    public class EnhancedPost : FacebookWrapper.ObjectModel.Post
    {
        public enum ePostConnectionOptions
        {
            Feed,
            Posts
        }

        public int NumOfComments => 
            m_DynamicData.comments.summary.total_count != null ?
            (int)m_DynamicData.comments.summary.total_count : 0;
        public int NumOfLikes => m_DynamicData.reactions?.summary?.total_count != null ?
            (int)m_DynamicData.reactions.summary.total_count : 0;
        public string ImageUrl => m_DynamicData.full_picture != null? 
            (string)m_DynamicData.full_picture : "";
        public DateTime? LastPostEdit
        {
            get
            {
                if (m_DynamicData.created_time != null)
                {
                    return DateTime.Parse(m_DynamicData.updated_time);
                }

                return null;
            }
        }
        public static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoad = new Dictionary<eLoadOptions, string>
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

        public void SetData(
            dynamic i_DynamicData, 
            eLoadOptions i_LoadOptions = eLoadOptions.None)
        {
            m_DynamicData = i_DynamicData;
            LoadOption = i_LoadOptions;
            InitializeAfterSet();
        }

        public override string ToString()
        {
            string returningString = $"{CreatedTime}|{Type}|";
            if (!string.IsNullOrEmpty(Message))
            {
                returningString += $"{Message}|";
            }

            return returningString;
        }
    }
}
