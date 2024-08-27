using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Buttons
{
    public class LoadInfoPicture : PictureBox, HasDataInfo
    {
        public eInfoChoice InfoChoice { get; set; }
        public object RecivedInfo { get; set; }
    }
}
