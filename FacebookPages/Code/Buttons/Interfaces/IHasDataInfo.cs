namespace FacebookPages.Code.Buttons.Interfaces
{
    public interface IHasDataInfo
    {
        eInfoChoice InfoChoice { get; set; }
        object ReceivedInfo { get; set; }
    }
}
