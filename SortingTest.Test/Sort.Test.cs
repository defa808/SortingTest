using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace SortingTest.Test
{
    [TestClass]
    public abstract class SorterTest
    {
        protected abstract ISorter<T> GetInstance<T>()
            where T : IComparable<T>;

        #region Tests_Sort

        [TestMethod]
        public void Sort_SortedIntArray_SameArray()
        {

            // arrange
            var expectedArray = new[] { 1, 2, 3 };
            var actualArray = new[] { 3, 1, 2 };

            var sorter = GetInstance<int>();

            // act
            var actual = sorter.Sort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actual.ToArray());





            // assert
        }

        [TestMethod]
        public void Sort_IntArrayWithNegativeNumber_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 4, 3, 2, 5, -1, -2 };
            int[] expectedArray = new[] { -2, -1, 2, 3, 4, 5 };
            var sorter = GetInstance<int>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());
        }

        [TestMethod]
        public void Sort_IntArrayTheSameNumbers_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1, 2, 1 };
            int[] expectedArray = new[] { 1, 1, 2 };
            var sorter = GetInstance<int>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        public void Sort_OneElementInArray_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1 };
            int[] expectedArray = new[] { 1 };
            var sorter = GetInstance<int>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_IntArrayEmpty_ExpectedException()
        {
            //arrange
            int[] actualArray = new int[0];
            var sorter = GetInstance<int>();

            //act
            var actual = sorter.Sort(actualArray);


        }

        [TestMethod]
        public void Sort_StringArrayWithNull_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { null, "he", "hello", "window" };
            var actualArray = new[] { "he", "hello", null, "window" };
            var sorter = GetInstance<string>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        public void Sort_StringArray_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { "a", "b", "c" };
            var actualArray = new[] { "b", "a", "c" };
            var sorter = GetInstance<string>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_StringArrayEmpty_ExpectedException()
        {
            //arrange
            var actualArray = new string[0];
            var sorter = GetInstance<string>();

            //act
            var actual = sorter.Sort(actualArray);

        }


        #endregion


    }
}
