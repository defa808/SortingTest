using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest.Test
{
    [TestClass]
    public class SorterTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sorter_WithNull_ExpectedException()
        {
            //Arrange
            int[] actualArray = { 2, 1 };
            int[] expectedArray = { 1, 2 };

            SortingArray<int> instance = new SortingArray<int>(actualArray);
            instance.Sorter = null;


            //Act
            instance.Sort();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void Sorter_IntArray_CorrectResult()
        {

            //Arrange
            int[] actualArray = { 2, 1 };
            int[] expectedArray = { 1, 2 };

            SortingArray<int> instance = new SortingArray<int>(actualArray)
            {
                Sorter = new BubbleSorter<int>()
            };

            //Act
            instance.Sort();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }
    }
}
