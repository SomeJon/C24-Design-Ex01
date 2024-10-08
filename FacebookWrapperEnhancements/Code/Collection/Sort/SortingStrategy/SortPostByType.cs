using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByType : ISortingStrategy
    {
        public Comparison<EnhancedPost> GetComparison()
        {
            return (i_FirstObject, i_SecondObject) =>
                {
                    string firstObjectType = i_FirstObject?.Type?.ToString() ?? string.Empty;
                    string secondObjectType = i_SecondObject?.Type?.ToString() ?? string.Empty;
                    return string.Compare(secondObjectType, firstObjectType, StringComparison.OrdinalIgnoreCase);
                };
        }

        public override string ToString()
        {
            return "Sort by Post Type";
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