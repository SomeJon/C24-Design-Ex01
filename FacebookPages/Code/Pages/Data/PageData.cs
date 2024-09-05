using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages.Data 
{
    public abstract class PageData : FacebookObject, IPageData, HasSetData
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

        private void FetchAndLoadData(Dictionary<string, string> i_KeyValueParamtersPairs = null)
        {
            string requestData = FieldsToLoad[eLoadOptions.Full];
            m_DynamicData = PageFetcherObject.Fetch(requestData, Connection, i_KeyValueParamtersPairs);
            LoadOption = DynamicWrapper.eLoadOptions.Full;
            InitializeAfterSet();
        }

        public virtual void TryFetchAndLoadPageData(
            UserFetchData i_FetchData = null, Dictionary<string, string> i_KeyValueParamtersPairs = null)
        {
            if (i_FetchData != null && !DataUserId.Equals(i_FetchData.UserId))
            {
                PageFetcherObject = new Fetcher(i_FetchData);
            }

            if (FetchNext || !string.IsNullOrEmpty(DataUserId))
            {
                try
                {
                    ResetForReFetch();
                    FetchAndLoadData(i_KeyValueParamtersPairs);
                    ConfirmLoad();
                } catch (Facebook.FacebookOAuthException i_FailedLoad)
                {
                    MessageBox.Show(i_FailedLoad.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public virtual void LoadFetchData(UserFetchData i_FetchData)
        {
            PageFetcherObject = new Fetcher(i_FetchData);
        }

        private void ConfirmLoad()
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
            dynamic i_DynamicCollection,
            ICollection<T> io_Collection,
            eLoadOptions i_LoadOptions = eLoadOptions.Full) 
            where T : HasSetData, new()
        {
            if(io_Collection != null && i_DynamicCollection != null)
            {
                foreach (dynamic item in i_DynamicCollection)
                {
                    T val = new T();
                    val.SetData(item, eLoadOptions.Full);
                    io_Collection.Add(val);
                }
            }
        } 

        public void SetData(dynamic i_DynamicData, eLoadOptions i_LoadOptions = eLoadOptions.None)
        {
            m_DynamicData = i_DynamicData;
            LoadOption = i_LoadOptions;
            InitializeAfterSet();
        }
    }
}
