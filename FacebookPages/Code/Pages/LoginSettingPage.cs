using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Data;

namespace FacebookPages.Code.Pages
{
    public partial class LoginSettingPage : Page
    {
        public override Color BackColor {  get; set; }

        internal LoginSettingPage()
        {
            InitializeComponent();
            appIdComboBox.DataSource = AppSetting.AppIds;

            appIdComboBox.SelectedIndex = 0;
        }

        private void addAppIdTextBox_KeyPress(object i_Sender, KeyPressEventArgs i_EventArgs)
        {
            if(!char.IsDigit(i_EventArgs.KeyChar))
            {
                i_EventArgs.Handled = true;
            }
        }

        private void backButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OnChangePage(i_Sender, i_EventArgs);
        }

        private void addIdButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (addAppIdTextBox.Text.Length > 0) {
                AppSetting.AppIds.Add(addAppIdTextBox.Text);
                appIdComboBox.SelectedIndex = appIdComboBox.Items.Count - 1;
            } else
            {
                MessageBox.Show("You need to first input an id in the Text Box!");
            }
        }

        private void appIdComboBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            AppSetting.AppId = (i_Sender as ComboBox)?.SelectedItem as string;
        }
    }
}
