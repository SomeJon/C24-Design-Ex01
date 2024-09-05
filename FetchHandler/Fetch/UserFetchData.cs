using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data
{
    public class UserFetchData
    {
        public string UserId { get; set; }
        public string AccessToekn { get; }

        public UserFetchData(string i_UserId, string i_AccessToekn)
        {
            UserId = i_UserId;
            AccessToekn = i_AccessToekn;
        }
    }
}
