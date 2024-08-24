using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data
{
    public abstract class PageData : IPageData
    {
        internal string DataUserId { get; set; }
        public bool FetchNext { get; set; } = true;

        public abstract void FetchAndLoadData(UserFetchData i_Fetcher);

        public void TryFetchAndLoadData(UserFetchData i_Fetcher)
        {
            if (FetchNext || DataUserId != i_Fetcher.UserId)
            {
                FetchAndLoadData(i_Fetcher);
                ConfirmLoad(i_Fetcher.UserId);
            }
        }

        protected void ConfirmLoad(string i_UserId)
        {
            DataUserId = i_UserId;
            FetchNext = false;
        }
    }
}
