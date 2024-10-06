using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Factory
{
    public class CustomPageRequest : IHasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
        public EnhancedUser NewPageOwner { get; set; }
    }
}