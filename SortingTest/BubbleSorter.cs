using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public class BubbleSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        public List<T> Sort(T[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("array is empty");
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] != null)

                        if (array[j+1] == null ||  array[j].CompareTo(array[j + 1]) > 0)
                        {
                            var tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                        }
                }
            }
            return array.ToList();
        }
    }
}
