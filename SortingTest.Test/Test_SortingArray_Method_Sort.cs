using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;

namespace SortingTest.Test
{
    
    [TestClass]
    public class Test_SortingArray_Method_Sort
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

        #region Tests_MoveNext
        [TestMethod]
        public void MoveNext_FinityCalling()
        {
            //arrange
            int[] actualArray = new[] { 1, 2 };
            SortingArray<int> instance = new SortingArray<int>(actualArray);

            //act
            bool flag = false;
            for (int i = 0; i < 4; i++)
            {
                flag = instance.MoveNext();

            }

            //assert
            Assert.IsFalse(flag);

        }
        #endregion



    }


}