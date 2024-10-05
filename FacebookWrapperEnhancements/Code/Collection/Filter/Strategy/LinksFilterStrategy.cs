﻿using FacebookWrapperEnhancements.Code.Post;
using System;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class LinksFilterStrategy : IFilterStrategy
    {
        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => i_Post.Type == FacebookWrapper.ObjectModel.Post.eType.link;
        }
    }
}