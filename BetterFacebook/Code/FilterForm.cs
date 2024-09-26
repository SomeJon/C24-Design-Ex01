using FacebookPages.Code.Pages.Data.Post.Filter;
using FacebookPages.Code.Pages.Data.Post.Sort;
using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
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

        public void LoadData(DataFilter iDataToLoad)
        {
            if (iDataToLoad != null)
            {
                m_PossibleUsersComboBox.DataSource = iDataToLoad.AvailableUsersToSelect;
                m_PossibleUsersComboBox.DisplayMember = "Name";
                m_PossibleUsersComboBox.SelectedItem = iDataToLoad.UserSource;

                m_SortList.SelectedIndex = (int)iDataToLoad.SortingMethod;

                foreach (var condition in iDataToLoad.Conditions)
                {
                    int index = (int)condition.Key;
                    if (index >= 0 && index < m_FilterCheckedList.Items.Count && condition.Value)
                    {
                        m_FilterCheckedList.SetItemChecked(index, true);
                    }
                }

                m_MinDatePicker.Value =
                    iDataToLoad.MinDate > m_MinDatePicker.MinDate && iDataToLoad.MinDate <= m_MaxDatePicker.MaxDate
                    ? iDataToLoad.MinDate
                    : m_MinDatePicker.MinDate;

                m_MaxDatePicker.Value =
                    iDataToLoad.MaxDate >= m_MinDatePicker.MinDate && iDataToLoad.MaxDate <= m_MaxDatePicker.MaxDate
                    ? iDataToLoad.MaxDate
                    : m_MaxDatePicker.MaxDate;

                m_ReverseOrderCheckBox.Checked = iDataToLoad.ReverseOrder;
                m_MatchAllFiltersCheckBox.Checked = iDataToLoad.MatchAllFilters;
                m_TextContainsBox.Text = iDataToLoad.TextContainsString ?? string.Empty;
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
