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
