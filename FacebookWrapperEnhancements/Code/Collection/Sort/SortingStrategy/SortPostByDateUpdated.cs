using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByDateUpdated : IPostSortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) => Nullable.Compare(i_SecondObject?.UpdateTime, i_FirstObject?.UpdateTime);
        }

        public override string ToString()
        {
            return "Sort by Date Updated";
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
