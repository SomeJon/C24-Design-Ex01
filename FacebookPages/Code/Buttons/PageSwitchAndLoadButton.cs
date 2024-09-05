using FacebookPages.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Buttons
{
    public class PageSwitchAndLoadButton : PageSwitchButton, HasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object RecivedInfo { get; set; }
    }
}
