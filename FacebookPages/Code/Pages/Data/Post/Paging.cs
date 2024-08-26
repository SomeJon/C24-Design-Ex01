using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class Paging : PageData
    {
        public string Previous 
        { 
            get 
            {
                return m_DynamicData.previous;
            
            }

            set 
            { 
                m_DynamicData = value;
            }
        }
        public string Next
        {
            get
            {
                return m_DynamicData.next;

            }

            set
            {
                m_DynamicData.next = value;
            }
        }

        public void Clear()
        {
            base.ResetForReFetch();
            Previous = string.Empty;
            Next = string.Empty;
        }
    }
}
