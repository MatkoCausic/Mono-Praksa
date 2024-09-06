using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions
{
    internal interface ISearchStrategy
    {
        int Search<T>(List<T> numbers,T target);
    }
}
