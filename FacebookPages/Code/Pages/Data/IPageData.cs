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
        void FetchAndLoadData(UserFetchData i_Fetcher);

        void TryFetchAndLoadData(UserFetchData i_Fetcher);
    }
}
