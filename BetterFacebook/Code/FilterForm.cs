using FacebookWrapper.ObjectModel;
using System;
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

        public FilterForm(FilterData i_FilterData)
        {
            InitializeComponent();

            m_MaxDatePicker.Value = DateTime.Now;
            m_SortList.SelectedIndex = 0;

            this.filterDataBindingSource.DataSource = i_FilterData;
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
