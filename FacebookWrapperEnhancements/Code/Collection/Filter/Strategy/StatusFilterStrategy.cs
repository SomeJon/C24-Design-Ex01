using System;
using FacebookWrapperEnhancements.Code.Post;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class StatusFilterStrategy : IFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => i_Post.Type == FacebookWrapper.ObjectModel.Post.eType.status;
        }
    }
}