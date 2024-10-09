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
        public List<IFilterStrategy> FilterStrategyChoices { get; }
        public List<ISortingStrategy> SortStrategiesChoices { get; }


        public FilterFormUtils()
        {
            FilterStrategyChoices = new List<IFilterStrategy>
                                        {
                                            r_LinksFilterStrategy,
                                            r_StatusFilterStrategy,
                                            r_PhotoFilterStrategy,
                                            r_ContainsPhotoFilterStrategy,
                                            r_ContainsTextFilterStrategy
                                        };

            SortStrategiesChoices = new List<ISortingStrategy>()
                                        {
                                            new SortPostsByDatePublished(),
                                            new SortPostByDateUpdated(),
                                            new SortPostByWriter(),
                                            new SortPostByType(),
                                            new SortPostsByLikes(),
                                            new SortPostsByNumOfComments()
                                        };
        }

        public Dictionary<IFilterStrategy, bool> GetDictionaryForSelectedChoices
            (List<IFilterStrategy> i_SelectedFilterStrategies)
        {

            Dictionary<Type, bool> typeDictionaryChoice = new Dictionary<Type, bool>();
            Dictionary<IFilterStrategy, bool> returnDictionary = new Dictionary<IFilterStrategy, bool>();

            foreach (IFilterStrategy filter in FilterStrategyChoices)
            {
                typeDictionaryChoice[filter.GetType()] = false;
            }

            foreach(IFilterStrategy filter in i_SelectedFilterStrategies)
            {
                typeDictionaryChoice[filter.GetType()] = true;
            }

            foreach (IFilterStrategy filter in FilterStrategyChoices)
            {
                returnDictionary[filter] = typeDictionaryChoice[filter.GetType()];
            }

            return returnDictionary;
        }
    }
}