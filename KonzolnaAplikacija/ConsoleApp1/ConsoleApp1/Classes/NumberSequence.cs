using ConsoleApp1.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class NumberSequence<T>
    {
        private List<T> _sequence;
        private int _sequenceSize;
        private SortStrategy<T>? _sortStrategy;
        private ISearchStrategy? _searchStrategy;

        public NumberSequence(int sequenceSize)
        {
            this._sequenceSize = sequenceSize;
            this._sequence = new List<T>();
            _sortStrategy = null;
            _searchStrategy = null;
        }
        public NumberSequence(List<T> sequence,int sequenceSize,SortStrategy<T> sortStrategy,ISearchStrategy searchStrategy)
        {
            this._sequence = sequence;
            this._sequenceSize = sequenceSize;
            this._sortStrategy = sortStrategy;
            this._searchStrategy = searchStrategy;
        }

        public NumberSequence(List<T> sequence)
            : this(sequence.Count)
        {
            _sequence = sequence;
        }

        public void Add(T item) => _sequence.Add(item);
        public void Remove(T item) => _sequence.Remove(item);
        public void Clear() => _sequence.Clear();
        public void InsertAt(int index,T value) =>this._sequence[index] = value;

        public void SetSortStrategy(SortStrategy<T> strategy) => this._sortStrategy = strategy;
        public void SetSearchStrategy(ISearchStrategy strategy) => this._searchStrategy = strategy;

        public void Sort() => this._sortStrategy.Sort(this._sequence);
        public void Search(T target) => this._searchStrategy.Search(this._sequence,target);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in this._sequence)
                builder.Append(item).Append(Environment.NewLine);
            return builder.ToString();
        }
    }
}
