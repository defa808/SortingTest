using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public class InsertSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        public List<T> Sort(T[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("array is empty");
            }

            int i, j;
            for (i = 0; i < array.Length; i++)
            {
                var x = array[i];
                for (j = i - 1; j >= 0 && array[j].CompareTo(x) > 0; j--)
                    array[j + 1] = array[j];

                array[j + 1] = x;
            }

            return array.ToList();
        }
    }
}
