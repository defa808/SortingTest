using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;

namespace SortingTest.Test
{
    
    [TestClass]
    public class Test_SortingArray_Method_Sort
    {
        //#region Tests_Sort

        //[TestMethod]
        //public void Sort_IntArray_CorrectArray()
        //{
        //    //arrange
        //    int[] actualArray = new[] { 4, 3, 2, 5, 1, 2 };
        //    int[] expectedArray = new[] { 1, 2, 2, 3, 4, 5 };

        //    SortingArray instance = new SortingArray(actualArray);
        //    //act
        //    instance.Sort();
        //    //assert
        //    CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        //}

        //[TestMethod]
        //public void Sort_IntArrayWithNegativeNumber_CorrectArray()
        //{
        //    //arrange
        //    int[] actualArray = new[] { 4, 3, 2, 5, -1, -2 };
        //    int[] expectedArray = new[] { -2, -1, 2, 3, 4, 5 };

        //    SortingArray instance = new SortingArray(actualArray);
        //    //act
        //    instance.Sort();
        //    //assert
        //    CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        //}

        //[TestMethod]
        //public void Sort_IntArrayTheSameNumbers_CorrectArray()
        //{
        //    //arrange
        //    int[] actualArray = new[] { 1, 2, 1 };
        //    int[] expectedArray = new[] { 1, 1, 2 };

        //    SortingArray instance = new SortingArray(actualArray);
        //    //act
        //    instance.Sort();
        //    //assert
        //    CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        //}

        //[TestMethod]
        //public void Sort_OneElementInArray_CorrectArray()
        //{
        //    //arrange
        //    int[] actualArray = new[] { 1 };
        //    int[] expectedArray = new[] { 1 };

        //    SortingArray instance = new SortingArray(actualArray);
        //    //act
        //    instance.Sort();
        //    //assert
        //    CollectionAssert.AreEqual(instance.CollectionArray, expectedArray);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        //public void Sort_IntArrayEmpty_ExpectedException()
        //{
        //    //arrange
        //    int[] actualArray = new int[0];

        //    SortingArray instance = new SortingArray(actualArray);
        //    //act
        //    instance.Sort();

        //}
        //#endregion

        #region Tests_Add
        [TestMethod]
        public void Add_OneElementInt_SuccessfullyAdding()
        {
            //arrange
            int[] actualArray = new int[0];
            SortingArray instance = new SortingArray(actualArray);
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
            SortingArray instance = new SortingArray(actualArray);
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
            SortingArray instance = new SortingArray(actualArray);

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