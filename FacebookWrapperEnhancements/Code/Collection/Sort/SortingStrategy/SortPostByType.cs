using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy
{
    public class SortPostByType : IPostSortingStrategy
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