using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class UpdatedPostData : FacebookWrapper.ObjectModel.Post, HasSetData
    {
        public int NumOfComments => (int)m_DynamicData.comments.summary.total_count;
        public int NumOfLikes => (int)m_DynamicData.reactions.summary.total_count;
        public string ImageUrl => (string)m_DynamicData.full_picture;
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

        public void SetData(dynamic i_DynamicData, eLoadOptions i_LoadOptions = eLoadOptions.None)
        {
            m_DynamicData = i_DynamicData;
            LoadOption = i_LoadOptions;
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
