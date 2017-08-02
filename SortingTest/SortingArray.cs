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
            _collectionArray = arr;
            
        }

        public void Sort()
        {
            throw new System.NotImplementedException();
        }

    }
}
