using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.Collection.Sort;

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

        public void LoadData(FilterData i_DataToLoad)
        {
            if (i_DataToLoad != null)
            {
                m_PossibleUsersComboBox.DataSource = i_DataToLoad.AvailableUsersToSelect;
                m_PossibleUsersComboBox.DisplayMember = "Name";
                m_PossibleUsersComboBox.SelectedItem = i_DataToLoad.UserSource;

                m_SortList.SelectedIndex = (int)i_DataToLoad.PostSortingMethod;

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

        public FilterData GetData()
        {
            FilterData dataFilter = new FilterData
            {
                                            UserSource = m_PossibleUsersComboBox.SelectedItem as User,
                                            AvailableUsersToSelect = m_PossibleUsersComboBox.Items.Cast<User>().ToList(),
                                            PostSortingMethod = (SortingMethodFactory.eSortingMethod)m_SortList.SelectedIndex,
                                            MinDate = m_MinDatePicker.Value,
                                            MaxDate = m_MaxDatePicker.Value,
                                            ReverseOrder = m_ReverseOrderCheckBox.Checked,
                                            MatchAllFilters = m_MatchAllFiltersCheckBox.Checked,
                                            TextContainsString = string.IsNullOrEmpty(m_TextContainsBox.Text) ? null : m_TextContainsBox.Text
                                        };

            foreach (object condition in Enum.GetValues(typeof(FilterMethod.eFilterCondition)))
            {
                int index = (int)condition;
                if (index >= 0 && index < m_FilterCheckedList.Items.Count)
                {
                    dataFilter.Conditions[(FilterMethod.eFilterCondition)condition] = m_FilterCheckedList.GetItemChecked(index);
                }
            }

            return dataFilter;
        }

        private void m_Cancel_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Close();
        }

        private void m_Confirm_Click(object i_Sender, EventArgs i_EventArgs)
        {
            Confirmed = true;
            this.Close();
        }
    }
}
