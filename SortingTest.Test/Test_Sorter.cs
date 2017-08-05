using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace SortingTest.Test
{
    [TestClass]
    public class Test_Sorter
    {
        #region Tests_Sort

        [TestMethod]
        public  void Sort_SortedIntArray_SameArray()
        {

            // arrange
            var expectedArray = new[] { 1, 2, 3 };
            var actualArray = new[] { 3, 1, 2 };
            var sorter = new Sorter<int>();

            // act
            var actual = sorter.Sort(actualArray);


            // assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());
        }

        [TestMethod]
        public void Sort_IntArrayWithNegativeNumber_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 4, 3, 2, 5, -1, -2 };
            int[] expectedArray = new[] { -2, -1, 2, 3, 4, 5 };
            var sorter = new Sorter<int>();

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
            var sorter = new Sorter<int>();

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
            var sorter = new Sorter<int>();

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
            var sorter = new Sorter<int>();

            //act
            var actual = sorter.Sort(actualArray);


        }

        [TestMethod]
        public void Sort_StringArrayWithNull_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { null, "he", "hello","window" };
            var actualArray = new[] { "he", "hello", null, "window" };
            var sorter = new Sorter<int>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        public void Sort_StringArray_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { "abc", "he", "hello", "window" };
            var actualArray = new[] { "he", "hello", "window", "abc" };
            var sorter = new Sorter<int>();

            //act
            var actual = sorter.Sort(actualArray);

            //assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_StringArrayEmpty_CorrectArray()
        {
            //arrange
            var actualArray = new string [0];
            var sorter = new Sorter<int>();

            //act
            var actual = sorter.Sort(actualArray);

        }

        [TestMethod]
        public void Sort_HugeArray_SortedArray()
        {
            // arrange
            var count = 20000000;
            var actualArray = new int[count];
            for (var i = actualArray.Length; i >= 0; --i)
            {
                actualArray[actualArray.Length-i] = i;
            }
            var expectedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                expectedArray[i] = i;
            }

            var sorter = new Sorter<int>();

            // diagnostic
            var sw = new Stopwatch();
            sw.Start();

            // act
            var actual = sorter.Sort(actualArray);


            sw.Stop();
            Trace.WriteLine($"Sorting time = {new TimeSpan(sw.ElapsedTicks):T}");

            // assert
            CollectionAssert.AreEqual(expectedArray, actual.ToArray());
        }


        #endregion

    }
}
