using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTest
{
    public class SortingArray : ISorter, IEnumerator, IEnumerable
    {

        private int[] _collectionArray;

        public int[] CollectionArray
        {
            get => _collectionArray;
        }

        int position = -1;

        public object Current
        {
            get {
                if (_collectionArray.Length == 0)
                    throw new InvalidOperationException("Collection is not set");

                return _collectionArray[position]; }
        }

        public SortingArray(int [] arr)
        {
            
            _collectionArray = arr;
            
        }

        public void Sort()
        {
            if (_collectionArray.Length == 0)
            {
                throw new InvalidOperationException("Collection is not set");
            }

            for (int i = _collectionArray.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (_collectionArray[j] > _collectionArray[j + 1])
                    {
                        int tmp = _collectionArray[j];
                        _collectionArray[j] = _collectionArray[j + 1];
                        _collectionArray[j + 1] = tmp;
                    }
                }
            }
        }


        public void Add(int item)
        {
            //throw new NotImplementedException();
            int[] temp = new int[_collectionArray.Length + 1];
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


    }
}
