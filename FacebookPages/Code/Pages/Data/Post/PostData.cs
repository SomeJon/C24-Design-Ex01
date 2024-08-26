using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostData : PageData
    {
        public string PostDate 
        { 
            get
            {
                return m_DynamicData.created_time;
            } 
        }

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
        }
    }
}
