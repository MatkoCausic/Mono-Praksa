using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes.Searches
{
    internal class LinearSearch : ISearchStrategy
    {
        public int Search<T>(List<T> numbers,T target)
        {
            for(int i = 0; i < numbers.Count; i++)
                if (Comparer<T>.Default.Compare( numbers[i],target) == 0)
                    return i;

            return -1;
        }
    }
}
