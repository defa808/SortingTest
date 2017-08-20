using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public class QuickSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        public List<T> Sort(T[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("array is empty");
            }

            quicksort(array, 0, array.Length - 1);


            return array.ToList();
        }

        private int partition(T[] m, int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)         
            {
                if (m[j] == null || m[j].CompareTo(m[b]) <= 0)  
                {
                    T t = m[i];                  
                    m[i] = m[j];                
                    m[j] = t;                    
                    i++;                         
                }
            }
            return i - 1;                        
        }


        private void quicksort(T[] m, int a, int b) 
        {                                        
            if (a.CompareTo(b) >= 0) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
    }

}
