using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class LoadInfoButton : Button
    {
        public enum eInfoChoice
        {
            AppId,
            Login,
            Exit,
        }

        public eInfoChoice InfoChoice { get; set;}
        public object RecivedInfo { get; set;}
    }
}
