using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Factory.Interfaces
{
    public interface IHasSwitchPage
    {
        ePageChoice PageChoice { get; set; }
        EnhancedUser NewPageOwner { get; set; }
    }
}
