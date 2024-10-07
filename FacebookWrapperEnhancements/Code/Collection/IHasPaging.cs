using FetchHandler.Fetch;
using System.Collections.ObjectModel;

namespace FacebookWrapperEnhancements.Code.Collection
{
    public interface IHasPaging
    {
        Paging PagingData { get; }

        IHasPaging FetchNextPage(string i_Id);
    }
}