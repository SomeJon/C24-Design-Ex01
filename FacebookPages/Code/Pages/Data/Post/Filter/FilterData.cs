using FacebookPages.Code.Pages.Data.Post.Sort;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookPages.Code.Pages.Data.Post.Sort.SortingMethod;

namespace FacebookPages.Code.Pages.Data.Post.Filter
{
    public class FilterData
    {
        public List<User> UsersSource { get; } = new List<User>();
        public List<User> AvailableUsersToSelect { get; } = new List<User>();
        public List<FilterMethod.eFilterCondition> Conditions { get; set; } = new List<FilterMethod.eFilterCondition>();
        public DateTime MinDate { get; set; }
        public DateTime MaxDate { get; set; }
        public SortingMethod.eSortingMethod SortingMethod { get; set; } = Sort.SortingMethod.eSortingMethod.ByDatePublished;
        public bool ReverseOrder { get; set; } = false;
        public string TextContainsString { get; set; } = null;
    }
}
