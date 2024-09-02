using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstractions;
using ConsoleApp1.Classes.Searches;
using ConsoleApp1.Classes.Sorts;

namespace ConsoleApp1.Classes
{
    internal class Director<T>
    {
        private IBuilder<T> _builder;
        public Director(IBuilder<T> builder)
        {
            _builder = builder;
        }
        
        public void ChangeBuilder(IBuilder<T> builder) => _builder = builder;
        public void MakeBinarySearch() => _builder.SetSortStrategy(new BubbleSort<T>()).SetSearchStrategy(new BinarySearch());
    }
}
