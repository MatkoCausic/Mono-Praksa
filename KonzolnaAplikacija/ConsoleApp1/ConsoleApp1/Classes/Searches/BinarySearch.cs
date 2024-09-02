using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes.Searches
{
    internal class BinarySearch : ISearchStrategy
    {
        public int Search<T>(List<T> numbers, T target)
        {
            if (IsSorted(numbers) != true)
                throw new Exception("Using binary search on an unsorted array.");
            int low = 0, high = numbers.Count - 1;
            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                if (Comparer<T>.Default.Compare(numbers[mid],target) == 0)
                    return mid;
                if (Comparer<T>.Default.Compare(numbers[mid], target) < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        private bool IsSorted<T>(List<T> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
                if (Comparer<T>.Default.Compare( numbers[i], numbers[i + 1]) > 0)
                    return false;
            return true;
        }
    }
}
