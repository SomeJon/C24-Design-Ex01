using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.Strategy
{
    public class ContainsTextFilterStrategy : IFilterStrategy
    {
        private readonly string r_TextToContain;

        public ContainsTextFilterStrategy(string i_TextToContain)
        {
            r_TextToContain = string.IsNullOrEmpty(i_TextToContain) ? string.Empty : i_TextToContain;
        }

        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => !string.IsNullOrEmpty(i_Post.Message) && i_Post.Message.Contains(r_TextToContain);
        }
    }
}