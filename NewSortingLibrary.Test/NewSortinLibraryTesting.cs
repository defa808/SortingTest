using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingLibrary;
using System.Diagnostics;

namespace NewSortingLibrary.Test
{
    [TestClass]
    public class NewSortinLibraryTesting 
    {

        #region Tests_Sort

        [TestMethod]
        public virtual void Sort_SortedIntArray_SameArray()
        {

            // arrange
            var expectedArray = new[] { 1, 2, 3 };
            var actualArray = new[] { 3, 1, 2 };

            SortingLibrary<int> instance = new SortingLibrary<int>(actualArray);

            // act
            instance.Sort();

            // assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());
        }

        [TestMethod]
        public void Sort_IntArrayWithNegativeNumber_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 4, 3, 2, 5, -1, -2 };
            int[] expectedArray = new[] { -2, -1, 2, 3, 4, 5 };

            SortingLibrary<int> instance = new SortingLibrary<int>(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());
        }

        [TestMethod]
        public void Sort_IntArrayTheSameNumbers_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1, 2, 1 };
            int[] expectedArray = new[] { 1, 1, 2 };

            SortingLibrary<int> instance = new SortingLibrary<int>(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());

        }

        [TestMethod]
        public void Sort_OneElementInArray_CorrectArray()
        {
            //arrange
            int[] actualArray = new[] { 1 };
            int[] expectedArray = new[] { 1 };

            SortingLibrary<int> instance = new SortingLibrary<int>(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_IntArrayEmpty_ExpectedException()
        {
            //arrange
            int[] actualArray = new int[0];

            SortingLibrary<int> instance = new SortingLibrary<int>(actualArray);
            //act
            instance.Sort();

        }

        [TestMethod]
        public void Sort_StringArrayWithNull_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { null, "he", "hello","window" };
            var actualArray = new[] { "he", "hello", null, "window" };


            SortingLibrary<string> instance = new SortingLibrary<string>(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());

        }

        [TestMethod]
        public void Sort_StringArray_CorrectArray()
        {
            //arrange
            var expectedArray = new[] { "abc", "he", "hello", "window" };
            var actualArray = new[] { "he", "hello", "window", "abc" };


            SortingLibrary<string> instance = new SortingLibrary<string>(actualArray);
            //act
            instance.Sort();
            //assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_StringArrayEmpty_CorrectArray()
        {
            //arrange
            var actualArray = new string [0];

            SortingLibrary<string> instance = new SortingLibrary<string>(actualArray);
            //act
            instance.Sort();

        }


        public  void Sort_HugeArray_SortedArray()
        {
            // arrange
            var count = 20000000;
            var array = new int[count];
            for (var i = array.Length; i >= 0; --i)
            {
                array[array.Length-i] = i;
            }
            var expectedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                expectedArray[i] = i;
            }

            var instance = new SortingLibrary<int>(array);

            // diagnostic
            var sw = new Stopwatch();
            sw.Start();

            // act
            instance.Sort();

            sw.Stop();
            Trace.WriteLine($"Sorting time = {new TimeSpan(sw.ElapsedTicks):T}");

            // assert
            CollectionAssert.AreEqual(expectedArray, instance.ToArray());
        }


        #endregion



    }
}
