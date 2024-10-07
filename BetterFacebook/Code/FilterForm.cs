using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.EnhancedObjects;


namespace FacebookClient.Code
{
    public partial class FilterForm : Form
    {
        public bool Confirmed { get; private set; } = false;
        private FilterData FilterData { get; }


        public FilterForm(FilterData i_FilterData)
        {
            InitializeComponent();
            FilterData = i_FilterData;

            customDataBinding();
            this.filterDataBindingSource.DataSource = FilterData;
        }

        private void customDataBinding()
        {
            m_SortList.DisplayMember = "Value";
            m_SortList.ValueMember = "Key";
            m_SortList.DataSource = new BindingSource(SortingMethodFactory.SortingOptions, null);


            Dictionary<string, bool> copiedDictionary = new Dictionary<string, bool>(FilterData.FilterOptions);
            foreach (KeyValuePair<string, bool> item in copiedDictionary)
            {
                m_FilterCheckedList.Items.Add(item.Key, item.Value);
            }

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
            string itemKey = (string)m_FilterCheckedList.Items[i_EventArgs.Index];

            FilterData.FilterOptions[itemKey] = (i_EventArgs.NewValue == CheckState.Checked);
        }
    }
}
