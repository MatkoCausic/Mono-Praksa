using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions
{
    internal abstract class SortStrategy<T>
    {
        public abstract void Sort(List<T> numbers);
        //public virtual void Sort<T>(T[] numbers) => Array.Sort(numbers);
        protected void Swap(T lhs,T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

    }
}
