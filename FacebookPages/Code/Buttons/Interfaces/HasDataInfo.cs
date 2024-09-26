namespace FacebookPages.Code.Buttons
{
    public interface IHasDataInfo
    {
        eInfoChoice InfoChoice { get; set; }
        object RecivedInfo { get; set; }
    }
}
