using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.Collection.Filter;


namespace FacebookClient.Code
{
    public partial class FilterForm : Form
    {
        public bool Confirmed { get; private set; } = false;
        private FilterData FilterData { get; }
        private FilterFormUtils m_FilterFormUtils = new FilterFormUtils();

        public FilterForm(FilterData i_FilterData)
        {
            InitializeComponent();
            FilterData = i_FilterData;

            customDataBinding();
            this.filterDataBindingSource.DataSource = FilterData;
            this.filterFormUtilsBindingSource.DataSource = m_FilterFormUtils;
        }

        private void customDataBinding()
        {
            Dictionary<IFilterStrategy, bool> copiedDictionary 
                = m_FilterFormUtils.GetDictionaryForSelectedChoices(FilterData.FilterStrategy.SelectedFilters);
            foreach (KeyValuePair<IFilterStrategy, bool> item in copiedDictionary)
            {
                m_FilterCheckedList.Items.Add(item.Key, item.Value);
            }

            //Loading the instances of the next filters to be used
            FilterData.FilterStrategy.SelectedFilters = copiedDictionary
                .Where(item => item.Value == true)
                .Select(item => item.Key)
                .ToList();
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

        private void m_FilterCheckedList_ItemCheck(object i_Sender, ItemCheckEventArgs i_EventArgs)
        {
            IFilterStrategy strategy = (IFilterStrategy)m_FilterCheckedList.Items[i_EventArgs.Index];

            if (i_EventArgs.NewValue == CheckState.Checked)
            {
                if (!FilterData.FilterStrategy.SelectedFilters.Contains(strategy))
                {
                    FilterData.FilterStrategy.SelectedFilters.Add(strategy);
                }

            }
            else if (i_EventArgs.NewValue == CheckState.Unchecked)
            {
                FilterData.FilterStrategy.SelectedFilters.Remove(strategy);
            }
        }
    }
}
