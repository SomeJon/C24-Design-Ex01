using FacebookPages.Code.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class PageSwitchButton : Button, HasSwitchPage
    {
        public ePageChoice PageChoice { get; set; }
    }
}
