using FacebookPages.Code.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Data
{
    public interface IPageData 
    {
        void TryFetchAndLoadData(UserFetchData i_FetchData, Dictionary<string, string> i_KeyValueParamtersPairs = null);
    }
}
