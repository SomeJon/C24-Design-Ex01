using FacebookPages.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Pages
{
    public partial class FriendsPage : BasePage
    {
        public FriendsPage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }
    }
}
