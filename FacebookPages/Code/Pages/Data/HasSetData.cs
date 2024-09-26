using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FacebookPages.Code.Pages.Data
{
    public interface IHasSetData
    {
        void SetData(dynamic iDynamicData, eLoadOptions iLoadOptions = eLoadOptions.None);
    }
}
