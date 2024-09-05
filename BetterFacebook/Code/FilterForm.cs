using FacebookPages.Code.Pages.Data.Post.Filter;
using FacebookPages.Code.Pages.Data.Post.Sort;
using FacebookWrapper.ObjectModel;
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
        public bool Confirmed { get; private set; } = false;

        public FilterForm()
        {
            InitializeComponent();
            m_MaxDatePicker.Value = DateTime.Now;
            m_SortList.SelectedIndex = 0;
        }

        public void LoadData(DataFilter i_DataToLoad)
        {
            if (i_DataToLoad != null)
            {
                m_PossibleUsersComboBox.DataSource = i_DataToLoad.AvailableUsersToSelect;
                m_PossibleUsersComboBox.DisplayMember = "Name";
                m_PossibleUsersComboBox.SelectedItem = i_DataToLoad.UserSource;

                m_SortList.SelectedIndex = (int)i_DataToLoad.SortingMethod;

                foreach (var condition in i_DataToLoad.Conditions)
                {
                    int index = (int)condition.Key;
                    if (index >= 0 && index < m_FilterCheckedList.Items.Count && condition.Value)
                    {
                        m_FilterCheckedList.SetItemChecked(index, true);
                    }
                }

                m_MinDatePicker.Value =
                    i_DataToLoad.MinDate > m_MinDatePicker.MinDate && i_DataToLoad.MinDate <= m_MaxDatePicker.MaxDate
                    ? i_DataToLoad.MinDate
                    : m_MinDatePicker.MinDate;

                m_MaxDatePicker.Value =
                    i_DataToLoad.MaxDate >= m_MinDatePicker.MinDate && i_DataToLoad.MaxDate <= m_MaxDatePicker.MaxDate
                    ? i_DataToLoad.MaxDate
                    : m_MaxDatePicker.MaxDate;

                m_ReverseOrderCheckBox.Checked = i_DataToLoad.ReverseOrder;
                m_MatchAllFiltersCheckBox.Checked = i_DataToLoad.MatchAllFilters;
                m_TextContainsBox.Text = i_DataToLoad.TextContainsString ?? string.Empty;
            }
        }


        public DataFilter GetData()
        {
            DataFilter dataFilter = new DataFilter
            {
                UserSource = m_PossibleUsersComboBox.SelectedItem as User,
                AvailableUsersToSelect = m_PossibleUsersComboBox.Items.Cast<User>().ToList(),
                SortingMethod = (SortingMethod.eSortingMethod)m_SortList.SelectedIndex,
                MinDate = m_MinDatePicker.Value,
                MaxDate = m_MaxDatePicker.Value,
                ReverseOrder = m_ReverseOrderCheckBox.Checked,
                MatchAllFilters = m_MatchAllFiltersCheckBox.Checked,
                TextContainsString = string.IsNullOrEmpty(m_TextContainsBox.Text) ? null : m_TextContainsBox.Text
            };

            foreach (var condition in Enum.GetValues(typeof(FilterMethod.eFilterCondition)))
            {
                int index = (int)condition;
                if (index >= 0 && index < m_FilterCheckedList.Items.Count)
                {
                    dataFilter.Conditions[(FilterMethod.eFilterCondition)condition] = m_FilterCheckedList.GetItemChecked(index);
                }
            }

            return dataFilter;
        }

        private void m_FillNumOfPostsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_Confirm_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }
    }
}
