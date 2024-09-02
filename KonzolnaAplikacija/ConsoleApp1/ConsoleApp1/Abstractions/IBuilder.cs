using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions
{
    internal interface IBuilder<T>
    {
        NumberSequence<T> Build();
        IBuilder<T> SetSequence(List<T> sequence);
        IBuilder<T> SetSequenceSize(int sequenceSize);
        IBuilder<T> SetSortStrategy(SortStrategy<T> sortStrategy);
        IBuilder<T> SetSearchStrategy(ISearchStrategy searchStrategy);
    }
}
