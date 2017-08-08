using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest.Test
{
    public class QuickSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        public IEnumerable<T> Sort(T[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("array is empty");
            }

            quicksort(array, 0, array.Length - 1);


            return array;
        }

        private int partition(T[] m, int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j] == null || m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    T t = m[i];                  // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    m[i] = m[j];                 // то есть переносим элементы меньшие m[b] в начало,
                    m[j] = t;                    // а затем и сам m[b] «сверху»
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }


        private void quicksort(T[] m, int a, int b) // a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a.CompareTo(b) >= 0) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
    }

}
