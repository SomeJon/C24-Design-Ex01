using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Buttons
{
    public class PageSwitchButton : Button
    {
        public enum ePageChoice
        {
            Login,
            Logout,
            Exit,
            LoginSetting,
            HomePage,
            PicturePage,
            AboutMePage,
            FriendPage,
            UseCase1Page,
            UseCase2Page,
        }

        public ePageChoice PageChoice { get; set; }
    }
}
