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
    public partial class SettingPage : BasePage
    {
        public override Color BackColor {  get; set; }

        public SettingPage()
        {
            InitializeComponent();
            appIdComboBox.Items.AddRange(new string[] {
                "867142571975316",
                "696056928008003",
                "1450160541956417"});

            appIdComboBox.SelectedIndex = 0;
        }

        private void addAppIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void addIdButton_Click(object sender, EventArgs e)
        {
            OnRecivedInfo(sender, e);
        }
    }
}
