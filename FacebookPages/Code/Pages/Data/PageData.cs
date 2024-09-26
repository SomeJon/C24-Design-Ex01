using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages.Data 
{
    public abstract class PageData : FacebookObject, IPageData, IHasSetData
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

        private void fetchAndLoadData(Dictionary<string, string> iKeyValueParamtersPairs = null)
        {
            string requestData = FieldsToLoad[eLoadOptions.Full];
            m_DynamicData = PageFetcherObject.Fetch(requestData, Connection, iKeyValueParamtersPairs);
            LoadOption = DynamicWrapper.eLoadOptions.Full;
            InitializeAfterSet();
        }

        public virtual void TryFetchAndLoadPageData(
            UserFetchData iFetchData = null, Dictionary<string, string> iKeyValueParamtersPairs = null)
        {
            if (iFetchData != null && !DataUserId.Equals(iFetchData.UserId))
            {
                PageFetcherObject = new Fetcher(iFetchData);
            }

            if (FetchNext || !string.IsNullOrEmpty(DataUserId))
            {
                try
                {
                    ResetForReFetch();
                    fetchAndLoadData(iKeyValueParamtersPairs);
                    confirmLoad();
                } catch (Facebook.FacebookOAuthException iFailedLoad)
                {
                    MessageBox.Show(iFailedLoad.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public virtual void LoadFetchData(UserFetchData iFetchData)
        {
            PageFetcherObject = new Fetcher(iFetchData);
        }

        private void confirmLoad()
        {
            DataUserId = PageFetcherObject.UserFetchData.UserId;
            FetchNext = false;
        }

        protected override void ResetForReFetch()
        {
            DataUserId = null;
            FetchNext = true;
            base.ResetForReFetch();
        }

        protected virtual void AddToCollection<T>(
            dynamic iDynamicCollection,
            ICollection<T> ioCollection,
            eLoadOptions iLoadOptions = eLoadOptions.Full) 
            where T : IHasSetData, new()
        {
            if(ioCollection != null && iDynamicCollection != null)
            {
                foreach (dynamic item in iDynamicCollection)
                {
                    T val = new T();
                    val.SetData(item, eLoadOptions.Full);
                    ioCollection.Add(val);
                }
            }
        } 

        public void SetData(dynamic iDynamicData, eLoadOptions iLoadOptions = eLoadOptions.None)
        {
            m_DynamicData = iDynamicData;
            LoadOption = iLoadOptions;
            InitializeAfterSet();
        }
    }
}
