using FacebookPages.Code.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class LoadInfoButton : Button, HasDataInfo
    {
        public eInfoChoice InfoChoice { get; set;}
        public object RecivedInfo { get; set;}
    }
}
