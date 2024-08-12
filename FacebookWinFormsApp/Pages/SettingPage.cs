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
    public partial class SettingPage : UserControl, PageControl
    {
        public event EventHandler RecivedInfo;
        public event EventHandler ChangePage;
        public string SelectedAppId { get; private set; }
        public override Color BackColor {  get; set; }

        public SettingPage()
        {
            InitializeComponent();
            appIdComboBox.Items.AddRange(new string[] {
                "867142571975316",
                "696056928008003",
                "1450160541956417"});

            SelectedAppId = "867142571975316";
            appIdComboBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (ChangePage != null)
            {
                ChangePage.Invoke(sender, EventArgs.Empty);
            }
        }

        private void appIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAppId = appIdComboBox.SelectedItem.ToString();
            if(RecivedInfo != null)
            {
                RecivedInfo(sender, EventArgs.Empty);
            }
        }

        private void addIdButton_Click(object sender, EventArgs e)
        {
            if(addAppIdTextBox.Text.Length > 0)
            {
                SelectedAppId = addAppIdTextBox.Text;
                appIdComboBox.Items.Add(SelectedAppId);
                appIdComboBox.SelectedIndex = appIdComboBox.Items.Count - 1;
            }
        }

        private void addAppIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
