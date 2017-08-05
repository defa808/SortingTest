using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public interface ISorter<T>
    {
        IEnumerable<T> Sort(T[] array);
    }
}
