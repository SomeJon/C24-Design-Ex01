using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostsByDatePublished : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) => Nullable.Compare(i_SecondObject?.CreatedTime, i_FirstObject?.CreatedTime);
        }

        public override string ToString()
        {
            return "Sort by Date Published";
        }

        public override bool Equals(object obj)
        {
            return obj != null && this.GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
    }
}