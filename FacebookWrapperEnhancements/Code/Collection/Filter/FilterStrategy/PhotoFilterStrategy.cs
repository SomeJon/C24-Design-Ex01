using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy
{
    public class PhotoFilterStrategy : IPostFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => i_Post.Type == FacebookWrapper.ObjectModel.Post.eType.photo;
        }

        public override string ToString()
        {
            return "Filter: Photo";
        }
    }
}