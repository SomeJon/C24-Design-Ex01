using FacebookWrapperEnhancements.Code.Collection.Filter;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using static FacebookWrapperEnhancements.Code.Collection.Sort.SortingMethodFactory;
using System.Linq;
using System;

namespace FacebookPages.Code.Buttons
{
    public class SortOptionsListBox : ListBox
    {
        private eSortingMethod m_SortOption;
        public eSortingMethod SortOption
        {
            get => m_SortOption;
            set
            {
                m_SortOption = value;
                this.SelectedItem = SortingOptions[m_SortOption];
            }
        }


        public SortOptionsListBox()
        {
            this.DisplayMember = "Value";
            this.ValueMember = "Key";

            this.DataSource = new BindingSource(SortingOptions, null);

            this.SelectedIndexChanged += SortOptionsListBox_SelectedIndexChanged;
        }

        private void SortOptionsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            // Find the enum value corresponding to the selected text
            string selectedText = (string)SelectedItem;
            eSortingMethod selectedSortingMethod = SortingMethodFactory.SortingOptions
                .FirstOrDefault(x => x.Value == selectedText).Key;

            // Update the sorting method reference
            m_SortOption = selectedSortingMethod;
        }
    }
}