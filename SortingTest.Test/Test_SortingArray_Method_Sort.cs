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
            int[] expectedArray = new[] { 1, 2, 2, 3, 4,5 };

            SortingArray instance = new SortingArray(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

    }
}
