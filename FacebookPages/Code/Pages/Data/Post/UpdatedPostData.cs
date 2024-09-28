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
