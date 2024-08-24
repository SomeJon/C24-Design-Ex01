using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data
{
    public abstract class PageData : FacebookObject, IPageData
    {
        internal string DataUserId { get; set; }
        public bool FetchNext { get; set; } = true;

        public virtual void FetchAndLoadData(UserFetchData i_FetcheData)
        {
            Fetcher fetch = new Fetcher(i_FetcheData);

            m_DynamicData = fetch.Fetch(FieldsToLoad[eLoadOptions.Full]);
            LoadOption = DynamicWrapper.eLoadOptions.Full;
            base.InitializeAfterSet();
        }

        public void TryFetchAndLoadData(UserFetchData i_Fetcher)
        {
            if (FetchNext || DataUserId != i_Fetcher.UserId)
            {
                ResetForReFetch();
                FetchAndLoadData(i_Fetcher);
                ConfirmLoad(i_Fetcher.UserId);
            }
        }

        protected void ConfirmLoad(string i_UserId)
        {
            DataUserId = i_UserId;
            FetchNext = false;
        }

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
        }
    }
}
