using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FacebookPages.Code.Pages.Data
{
    public interface IHasSetData
    {
        void SetData(dynamic i_DynamicData, eLoadOptions i_LoadOptions = eLoadOptions.None);
    }
}
