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
    public partial class LoginPage : BasePage
    {

        public override Color BackColor {  get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }
    }
}
