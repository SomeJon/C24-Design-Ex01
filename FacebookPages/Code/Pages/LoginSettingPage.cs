using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookPages.Code.Buttons;

namespace FacebookPages.Code.Pages
{
    public partial class LoginSettingPage : Page
    {
        public override Color BackColor {  get; set; }

        public LoginSettingPage()
        {
            InitializeComponent();
            appIdComboBox.Items.AddRange(new object[] {
                                                          "867142571975316",
                                                          "696056928008003",
                                                          "1450160541956417"});

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
                ((LoadInfoButton)i_Sender).ReceivedInfo = addAppIdTextBox.Text;
                appIdComboBox.Items.Add(addAppIdTextBox.Text);
                appIdComboBox.SelectedIndex = appIdComboBox.Items.Count - 1;
                OnReceivedInfo(i_Sender, i_EventArgs);
            } else
            {
                MessageBox.Show("You need to first input an id in the Text Box!");
            }
        }

        private void pictureBoxReturn_Click(object i_Sender, EventArgs i_EventArgs)
        {
           OnChangePage(i_Sender, i_EventArgs);        
        }
    }
}
