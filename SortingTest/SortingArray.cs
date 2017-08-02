﻿using System;
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
            _collectionArray = arr;

        }

        public void Sort()
        {
            //throw new System.NotImplementedException();
            _collectionArray = ParallelSort(_collectionArray);
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
