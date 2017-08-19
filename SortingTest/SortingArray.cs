using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTest
{
    public class SortingArray<T> : ISorteble, IEnumerator, IEnumerable
        where T : IComparable<T>
    {

        private ISorter<T> _sorter;

        private List<T> _collectionArray;

        private object locker = new object();

        public ISorter<T> Sorter { set => _sorter = value; get => _sorter; }


        public List<T> CollectionArray => _collectionArray;


        int position = -1;

        public object Current
        {
            get
            {
                if (_collectionArray.Count() == 0)
                    throw new InvalidOperationException("Collection is not set");

                return _collectionArray;
            }
        }

        public int Count => _collectionArray.Count();

        public SortingArray(IEnumerable<T> arr)
        {

            _collectionArray = arr.ToList();

        }

        public void Sort()
        {
            //lock (locker)
            //{
                if (_sorter == null)
                {
                    throw new InvalidOperationException("Sorter is null");
                }

                _collectionArray = _sorter.Sort(_collectionArray.ToArray());
            //}
        }


        public void Add(T value)
        {
            lock (_collectionArray)
                _collectionArray.Add(value);
            

        }

        public void RemoveLast()
        {
            //lock (_collectionArray)
                _collectionArray.Remove(_collectionArray.Last());

        }



        public bool MoveNext()
        {
            if (position < _collectionArray.Count() - 1)
            {
                position++;
                return true;
            }
            return false;
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
