using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTest
{
    public class SortingArray : ISorteble, IEnumerator, IEnumerable, ICollection
    {

        private int[] _collectionArray;

        public int[] CollectionArray => _collectionArray;


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

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public SortingArray(int[] arr)
        {

            _collectionArray = arr;

        }

        public void Sort()
        {
            this.Sort(3);
        }


        public void Sort(int x)
        {
            if (_collectionArray.Length == 0)
            {
                throw new InvalidOperationException("Collection is not set");
            }

            if (x == 1)
            {
                var sorter = new BubbleSorter<int>();
                var temp = sorter.Sort(_collectionArray);
                var i = 0;
                foreach (var item in temp)
                {
                    _collectionArray[i] = item;
                    ++i;
                }
            }
            else
            {
                if (x == 2)
                {
                    var sorter = new InsertSorter<int>();
                    var temp = sorter.Sort(_collectionArray);
                    var i = 0;
                    foreach (var item in temp)
                    {
                        _collectionArray[i] = item;
                        ++i;
                    }
                }
                else
                {
                    var sorter = new QuickSorter<int>();
                    var temp = sorter.Sort(_collectionArray);
                    var i = 0;
                    foreach (var item in temp)
                    {
                        _collectionArray[i] = item;
                        ++i;
                    }
                }
            }


        }


        public void Add(int item)
        {
            var temp = new int[_collectionArray.Length + 1];
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
            return new SortingArray(_collectionArray);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        
    }
}
