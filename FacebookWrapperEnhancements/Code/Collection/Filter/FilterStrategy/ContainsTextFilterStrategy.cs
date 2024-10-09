using System;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy
{
    public class ContainsTextFilterStrategy : IFilterStrategy
    {
        public string TextToContain { get; set; }

        public ContainsTextFilterStrategy()
        {
            TextToContain = string.Empty;
        }

        public ContainsTextFilterStrategy(string i_TextToContain)
        {
            TextToContain = string.IsNullOrEmpty(i_TextToContain) ? string.Empty : i_TextToContain;
        }

        public Predicate<EnhancedPost> GetPredicate()
        {
            return i_Post => !string.IsNullOrEmpty(i_Post.Message) && i_Post.Message.Contains(TextToContain);
        }

        public override string ToString()
        {
            return "Filter: Text Contained";
        }
    }
}