using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class ContainsPhotoFilterStrategy : IFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => !string.IsNullOrEmpty(i_Post.ImageUrl);
        }
    }
}