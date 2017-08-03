using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest
{
    public class SortingArray : ISorter
    {

        private int[] _collectionArray;

        public int[] CollectionArray
        {
            get => _collectionArray;
        }

        public SortingArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("Collection is not set");

            }
            _collectionArray = arr;

        }

        public void Sort()
        {
            //for (int i = _collectionArray.Length - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (_collectionArray[j] > _collectionArray[j + 1])
            //        {
            //            int tmp = _collectionArray[j];
            //            _collectionArray[j] = _collectionArray[j + 1];
            //            _collectionArray[j + 1] = tmp;
            //        }
            //    }
            //}
            //throw new System.NotImplementedException();
            QuickSort(0, _collectionArray.Length - 1);
        }


        public void Add(int item)
        {
            throw new NotImplementedException();

        }

        void QuickSort(int a, int b)
        {
            if (a >= b) return;
            int c = partition(a, b);
            QuickSort(a, c - 1);
            QuickSort(c + 1, b);
        }

        int partition(int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)
            {
                if (_collectionArray[j] <= _collectionArray[b])
                {
                    int t = _collectionArray[i];
                    _collectionArray[i] = _collectionArray[j];
                    _collectionArray[j] = t;
                    i++;
                }
            }
            return i - 1;
        }
    }
}
