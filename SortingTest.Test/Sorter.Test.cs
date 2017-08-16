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


            //Act
            instance.Sort();

            //Assert
            Assert.AreEqual(expectedArray, instance);

        }
    }
}
