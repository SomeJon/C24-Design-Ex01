using System;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class UpdatedPostData : FacebookWrapper.ObjectModel.Post, IHasSetData
    {
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

        public void SetData(dynamic iDynamicData, eLoadOptions iLoadOptions = eLoadOptions.None)
        {
            m_DynamicData = iDynamicData;
            LoadOption = iLoadOptions;
            InitializeAfterSet();
        }

        public override string ToString()
        {
            string returningString = string.Empty;
            
            returningString = $"{CreatedTime}|{Type}|";
            if (!string.IsNullOrEmpty(Message))
            {
                returningString += $"{Message}|";
            }

            return returningString;
        }
    }
}
