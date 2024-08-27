using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Buttons
{
    public interface HasDataInfo
    {
        eInfoChoice InfoChoice { get; set; }
        object RecivedInfo { get; set; }
    }
}
