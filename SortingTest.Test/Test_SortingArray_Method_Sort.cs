using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class Test_SortingArray_Method_Sort
    {





        [TestMethod]
        public void Sort_IntArray_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 4, 3, 2, 5, 1, 2 };
            int[] expectedArray = new[] { 1, 2, 2, 3, 4, 5 };

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        [TestMethod]
        public void Sort_IntArrayWithNegativeNumber_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 4, 3, 2, 5, -1, -2 };
            int[] expectedArray = new[] { -2, -1, 2, 3, 4, 5 };

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        [TestMethod]
        public void Sort_IntArrayTheSameNumbers_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1, 2, 1 };
            int[] expectedArray = new[] { 1, 1, 2 };

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        [TestMethod]
        public void Sort_OneElementInArray_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1 };
            int[] expectedArray = new[] { 1 };

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_IntArrayEmpty_ExpectedException()
        {
            //arrange
            int[] actualArray = new int[0];

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();

        }


    }
}
