using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes.Sorts
{
    internal class SelectionSort<T> : SortStrategy<T>
    {
        public override void Sort(List<T> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int smallestValueIndex = i;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (Comparer<T>.Default.Compare(numbers[smallestValueIndex],numbers[j]) > 0)
                        smallestValueIndex = j;
                }
                //Swap(numbers[i],numbers[smallestValueIndex]);
                T temp = numbers[i];
                numbers[i] = numbers[smallestValueIndex];
                numbers[smallestValueIndex] = temp;
            }
        }
    }
}
