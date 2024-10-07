using FacebookWrapperEnhancements.Code.Collection.Filter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Buttons
{
    public class FilterCheckedListBox : CheckedListBox
    {
        private Dictionary<FilterMethod.eFilterCondition, bool> m_FilterConditionsState;
        public Dictionary<FilterMethod.eFilterCondition, bool> FilterConditionsState
        {
            get => m_FilterConditionsState;
            set
            {
                m_FilterConditionsState = value;
                updateCheckedListBox();
            }
        }

        public FilterCheckedListBox()
        {
            ItemCheck += FilterCheckedListBox_ItemCheck;
        }

        private void updateCheckedListBox()
        {
            Items.Clear(); // Clear existing items
            if (FilterConditionsState != null)
            {
                foreach (KeyValuePair<FilterMethod.eFilterCondition, bool> condition in FilterConditionsState)
                {
                    string friendlyName = FilterMethod.FilterOptions[condition.Key]; // Translate enum to string
                    Items.Add(friendlyName, condition.Value); // Add item with checked state
                }
            }
        }

        private void FilterCheckedListBox_ItemCheck(object i_Sender, ItemCheckEventArgs i_EventArgs)
        {
            // Get the friendly name of the item being checked/unchecked
            string selectedFriendlyName = Items[i_EventArgs.Index].ToString();

            // Find the corresponding enum value by reverse lookup in the FilterOptions dictionary
            FilterMethod.eFilterCondition selectedCondition = FilterMethod.FilterOptions
                .FirstOrDefault(x => x.Value == selectedFriendlyName).Key;

            // Update the Conditions dictionary based on the checked state
            FilterConditionsState[selectedCondition] = i_EventArgs.NewValue == CheckState.Checked;
        }
    }
}
