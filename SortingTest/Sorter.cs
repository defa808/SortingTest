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
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            return array;
        }
    }
}
