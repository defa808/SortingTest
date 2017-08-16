using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTest
{
    public class SortingArray<T> : ISorteble, IEnumerator, IEnumerable
        where T:IComparable<T>
    {

        private ISorter<T> _sorter = new BubbleSorter<T>();

        public ISorter<T> Sorter { set { _sorter = value; } get => _sorter; }

        private T[] _collectionArray;

        public T[] CollectionArray => _collectionArray;


        int position = -1;

        public object Current
        {
            get
            {
                if (_collectionArray.Length == 0)
                    throw new InvalidOperationException("Collection is not set");

                return _collectionArray[position];
            }
        }

        public int Count => _collectionArray.Length;

        public SortingArray(T[] arr)
        {   

            _collectionArray = arr;

        }

        public  void Sort()
        {
            var temp = _sorter.Sort(_collectionArray);
            var i = 0;
            foreach (var item in temp)
            {
                _collectionArray[i] = item;
                i++;
            }
        }




        public void Add(T item)
        {
            var temp = new T[_collectionArray.Length + 1];
            _collectionArray.CopyTo(temp, 0);
            temp[_collectionArray.Length] = item;
            _collectionArray = temp;
        }

        public bool MoveNext()
        {
            if (position < _collectionArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        public IEnumerator GetEnumerator()
        {
            return new SortingArray<T>(_collectionArray);
        }




    }
}
