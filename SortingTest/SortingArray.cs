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

        public SortingArray(int [] arr)
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
        }


        public void Add(int item)
        {
            throw new NotImplementedException();

        }

       
    }
}
