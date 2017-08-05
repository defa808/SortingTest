using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingLibrary
{
    public class SortingLibrary<T> : ISorter<T>, IEnumerable
        where T: IComparable<T>
    {

        private IEnumerable<T> _collectionArray;

        public IEnumerable<T> CollectionArray => _collectionArray;
        

        public SortingLibrary(IEnumerable<T> arr)
        {
            if (arr == null)
            {
                throw new InvalidOperationException("arr is empty");
            }
            _collectionArray = arr;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        public IEnumerable Sort()
        {
            throw new NotImplementedException();
        }

        public IEnumerable Sort(IEnumerable array)
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            return _collectionArray.ToArray();
        }
    }
}
