using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public class Sorter<T> : ISorter<T>
        where T:IComparable
    {
        public IEnumerable<T> Sort(T[] array)
        {
            throw new InvalidOperationException();
        }
    }
}
