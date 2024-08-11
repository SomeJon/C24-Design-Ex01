using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.New_Buttons
{
    public partial class LoginPage : UserControl, PageControl
    {
        public event EventHandler SelectedChoice;

        public override Color BackColor {  get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (SelectedChoice != null)
            {
                SelectedChoice.Invoke(sender, EventArgs.Empty);
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if (SelectedChoice != null)
            {
                SelectedChoice.Invoke(sender, EventArgs.Empty);
            }
        }
    }
}
