using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Data 
{
    public interface IPageData
    {
        EnhancedUser PageUser { get; }

        void LoadAllCurrentData();

        void RefreshData();
    }
}
