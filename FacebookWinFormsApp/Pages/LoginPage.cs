using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Pages
{
    public partial class LoginPage : UserControl, PageControl
    {
        public event EventHandler ChangePage;

        public override Color BackColor {  get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ChangePage != null)
            {
                ChangePage.Invoke(sender, EventArgs.Empty);
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if (ChangePage != null)
            {
                ChangePage.Invoke(sender, EventArgs.Empty);
            }
        }
    }
}
