using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.Collection.Filter;

namespace FacebookClient.Code
{
    public class Utils
    {
        public static bool CloseConfirm()
        {
            const string k_Message = "Are you sure that you would to exit this amazing facebook app?";
            const string k_Caption = "Exit the best facebook experience";
            DialogResult result = MessageBox.Show(k_Message, k_Caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
