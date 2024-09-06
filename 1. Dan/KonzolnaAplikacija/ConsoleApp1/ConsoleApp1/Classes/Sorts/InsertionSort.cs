using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes.Sorts
{
    internal class InsertionSort<T> : SortStrategy<T>
    {
        public override void Sort(List<T> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                T key = numbers[i];
                int j = i - 1;

                while (j >= 0 && Comparer<T>.Default.Compare(numbers[j],key) > 0)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
        }
    }
}
