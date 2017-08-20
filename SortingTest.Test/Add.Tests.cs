using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;

namespace SortingTest.Test
{
    
    [TestClass]
    public class Add
    {

        #region Tests_Add
        [TestMethod]
        public void Add_OneElementInt_SuccessfullyAdding()
        {
            //arrange
            int[] actualArray = new int[0];
            SortingArray<int> instance = new SortingArray<int>(actualArray);
            int[] expectedArray = new[] { 10 };

            //act
            instance.Add(10);

            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        [TestMethod]
        public void Add_OneElementNegativeNumber_SuccessfullyAdding()
        {
            //arrange
            int[] actualArray = new int[0];
            SortingArray<int> instance = new SortingArray<int>(actualArray);
            int[] expectedArray = new[] { -10 };

            //act
            instance.Add(-10);

            //assert
            CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        }

        #endregion

        



    }


}