using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;

namespace ConsoleApp1.Classes.Sorts
{
    internal class BubbleSort<T> : SortStrategy<T>
    {
        public override void Sort(List<T> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    //if (numbers[j] > numbers[j+1])
                    if (Comparer<T>.Default.Compare(numbers[j], numbers[j + 1]) > 0)
                    {
                        //Swap(numbers[j],numbers[j + 1]);
                        T temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                }
            }
        }
    }
}
