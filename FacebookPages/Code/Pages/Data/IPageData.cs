using FacebookPages.Code.Pages.Data;
using System.Collections.Generic;

namespace FacebookPages.Pages.Data
{
    public interface IPageData 
    {
        void TryFetchAndLoadPageData(UserFetchData iFetchData, Dictionary<string, string> iKeyValueParamtersPairs = null);

        void LoadFetchData(UserFetchData iFetchData);
    }
}
