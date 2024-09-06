using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes
{
    internal class NumberSequenceBuilder<T> : IBuilder<T>
    {
        private List<T>? _sequence;
        private int _sequenceSize;
        private SortStrategy<T>? _sortStrategy;
        private ISearchStrategy? _searchStrategy;

        public IBuilder<T> SetSequence(List<T> sequence) 
        {
            _sequence = sequence;
            return this;
        }
        public IBuilder<T> SetSequenceSize(int sequenceSize)
        {
            _sequenceSize = sequenceSize;
            return this;
        }
        public IBuilder<T> SetSortStrategy(SortStrategy<T> sortStrategy)
        {
            _sortStrategy = sortStrategy;
            return this;
        }
        public IBuilder<T> SetSearchStrategy(ISearchStrategy searchStrategy)
        {
            _searchStrategy = searchStrategy;
            return this;
        }
        public NumberSequence<T> Build() => new NumberSequence<T>(_sequence, _sequenceSize,_sortStrategy,_searchStrategy);
    }
}
