using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if(arr.Length == 0)
            {
                throw new InvalidOperationException("Collection is not set");

            }
            _collectionArray = arr;

        }

        public void Sort()
        {
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
            //throw new System.NotImplementedException();
            //_collectionArray = ParallelSort(_collectionArray);
        }


        public void Add(int item)
        {
            throw new NotImplementedException();

        }

        static int[] ParallelSort(int[] array)
        {
            if (array.Length == 1)
                return array;
            int midPoint = array.Length / 2;
            return ParallelSort(ParallelSort(array.Take(midPoint).ToArray()), ParallelSort(array.Skip(midPoint).ToArray()));
        }

        static int[] ParallelSort(int[] array1, int[] array2)
        {
            int a = 0, b = 0;
            int[] merged = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length + array2.Length; i++)
            {
                if (b.CompareTo(array2.Length) < 0 && a.CompareTo(array1.Length) < 0)
                    if (array1[a].CompareTo(array2[b]) > 0)
                        merged[i] = array2[b++];
                    else
                        merged[i] = array1[a++];
                else
                    if (b < array2.Length)
                    merged[i] = array2[b++];
                else
                    merged[i] = array1[a++];
            }
            return merged;
        }
    }
}
