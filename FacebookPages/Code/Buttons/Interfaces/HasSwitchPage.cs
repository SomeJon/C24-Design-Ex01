using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Buttons
{
    public interface HasSwitchPage
    {
        ePageChoice PageChoice { get; set; }
    }
}
