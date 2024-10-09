using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByWriter : IPostSortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) => string.Compare(i_SecondObject?.Name, i_FirstObject?.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return "Sort by Writer";
        }

        public override bool Equals(object i_Obj)
        {
            return i_Obj != null && this.GetType() == i_Obj.GetType();
        }

        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
    }
}