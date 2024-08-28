using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Code
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
            m_MaxDatePicker.Value = DateTime.Now;
            m_SortList.SelectedIndex = 0;
        }

        private void m_FillNumOfPostsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_AddUserButton_Click(object sender, EventArgs e)
        {
            if(m_PossibleUsersComboBox.SelectedItem != null) 
            {
                m_ListOfSelectedUsers.Items.Add(m_PossibleUsersComboBox.SelectedItem);
                m_PossibleUsersComboBox.Items.Remove(m_PossibleUsersComboBox.SelectedItem);
            }
        }
    }
}
