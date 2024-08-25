using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data
{
    public abstract class PageData : FacebookObject, IPageData
    {
        private Fetcher m_PageFetcherObject;
        protected string DataUserId { get; set; } = string.Empty;
        public string Connection { get; set; } = string.Empty;
        public bool FetchNext { get; set; } = true;
        public Fetcher PageFetcherObject {
            get
            {
                return m_PageFetcherObject;
            }

            set 
            {
                DataUserId = value.UserFetchData.UserId;
                FetchNext = true;
                m_PageFetcherObject = value;
            } 
        }

        public virtual void FetchAndLoadData()
        {
            m_DynamicData = PageFetcherObject.Fetch(FieldsToLoad[eLoadOptions.Full], Connection);
            LoadOption = DynamicWrapper.eLoadOptions.Full;
            InitializeAfterSet();
        }

        public void TryFetchAndLoadData(UserFetchData i_FetchData = null)
        {
            if (i_FetchData != null && !DataUserId.Equals(i_FetchData.UserId))
            {
                PageFetcherObject = new Fetcher(i_FetchData);
            }

            if (FetchNext && !string.IsNullOrEmpty(DataUserId))
            {
                ResetForReFetch();
                FetchAndLoadData();
                ConfirmLoad(i_FetchData.UserId);
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

        protected virtual void AddToCollection<T>(
            dynamic i_DynamicCollection,
            ICollection<T> io_Collection,
            eLoadOptions i_LoadOptions = eLoadOptions.Full) 
            where T : DynamicWrapper, new()
        {
            if(io_Collection != null && i_DynamicCollection != null)
            {
                foreach (dynamic item in i_DynamicCollection)
                {
                    T val = new T();
                    m_DynamicData = item;
                    LoadOption = i_LoadOptions;
                    io_Collection.Add(val);
                }
            }
        } 
    }
}
