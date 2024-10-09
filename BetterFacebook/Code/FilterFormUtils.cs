using System;
using FacebookWrapperEnhancements.Code.Collection.Filter;
using System.Collections.Generic;
using FacebookWrapperEnhancements.Code.Collection.Filter.FilterStrategy;
using FacebookWrapperEnhancements.Code.Collection.Sort;
using FacebookWrapperEnhancements.Code.Collection.Sort.SortingStrategy;

namespace FacebookClient.Code
{
    public class FilterFormUtils
    {
        private readonly LinksFilterStrategy r_LinksFilterStrategy = new LinksFilterStrategy();
        private readonly StatusFilterStrategy r_StatusFilterStrategy = new StatusFilterStrategy();
        private readonly PhotoFilterStrategy r_PhotoFilterStrategy = new PhotoFilterStrategy();
        private readonly ContainsPhotoFilterStrategy r_ContainsPhotoFilterStrategy = new ContainsPhotoFilterStrategy();
        private readonly ContainsTextFilterStrategy r_ContainsTextFilterStrategy = new ContainsTextFilterStrategy();
        public string TextContainsString
        {
            get => r_ContainsTextFilterStrategy.TextToContain;
            set => r_ContainsTextFilterStrategy.TextToContain = value;
        }
        public List<IPostFilterStrategy> FilterStrategyChoices { get; }
        public List<IPostSortingStrategy> SortStrategiesChoices { get; }


        public FilterFormUtils()
        {
            FilterStrategyChoices = new List<IPostFilterStrategy>
                                        {
                                            r_LinksFilterStrategy,
                                            r_StatusFilterStrategy,
                                            r_PhotoFilterStrategy,
                                            r_ContainsPhotoFilterStrategy,
                                            r_ContainsTextFilterStrategy
                                        };

            SortStrategiesChoices = new List<IPostSortingStrategy>()
                                        {
                                            new SortPostsByDatePublished(),
                                            new SortPostByDateUpdated(),
                                            new SortPostByWriter(),
                                            new SortPostByType(),
                                            new SortPostsByLikes(),
                                            new SortPostsByNumOfComments()
                                        };
        }

        public Dictionary<IPostFilterStrategy, bool> GetDictionaryForSelectedChoices
            (List<IPostFilterStrategy> i_SelectedFilterStrategies)
        {

            Dictionary<Type, bool> typeDictionaryChoice = new Dictionary<Type, bool>();
            Dictionary<IPostFilterStrategy, bool> returnDictionary = new Dictionary<IPostFilterStrategy, bool>();

            foreach (IPostFilterStrategy filter in FilterStrategyChoices)
            {
                typeDictionaryChoice[filter.GetType()] = false;
            }

            foreach(IPostFilterStrategy filter in i_SelectedFilterStrategies)
            {
                typeDictionaryChoice[filter.GetType()] = true;
            }

            foreach (IPostFilterStrategy filter in FilterStrategyChoices)
            {
                returnDictionary[filter] = typeDictionaryChoice[filter.GetType()];
            }

            return returnDictionary;
        }
    }
}