namespace FacebookPages.Code.Pages.Factory.Interfaces
{
    public interface IHasDataInfo
    {
        eInfoChoice InfoChoice { get; set; }
        object ReceivedInfo { get; set; }
    }
}
