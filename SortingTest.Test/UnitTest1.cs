using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class UnitTest1
    {

        SortingArray instance = new SortingArray();

        [TestMethod]
        public void Sort_IntArray_CorrectArray()
        {
            // arrange 
            var array = new[] { 1, 2, 3 };
            int[] myArray = { 1, 3, 2 };

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);
        }

        [TestMethod]
        public void SortTwice_IntArray_CorrectArray()
        {
            // arrange 
            var array = new[] { 1, 2, 3 };
            int[] myArray = { 1, 3, 2 };

            //act
            instance.Sort(myArray);
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);

        }

        [TestMethod]
        public void Sort_IntArrayWithNegative_CorrectArray()
        {
            // arrange 
            var array = new[] { -1, 1, 2, 3 };
            int[] myArray = { 1, 3, 2, -1 };

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);

        }

        [TestMethod]
        public void Sort_IntArrayEmpty_WithException()
        {
            //arrange
            int[] myArray = { };

            //act
            bool flag = false;
            instance.Sort(myArray);
            flag = true;

            if (flag)
            {
                throw new Exception("Sorting Empty Array!");
            }


        }

        [TestMethod]
        public void Sort_IntArrayOneElement_WithoutException()
        {
            //arrange
            int[] myArray = { 1 };

            //act
            try
            {
                instance.Sort(myArray);
            }
            catch
            {
                throw new Exception("Can't sort array with one element");
            }

        }

        [TestMethod]
        public void Sort_BigIntArray_CorrectArray()
        {
            // arrange 
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }

            int[] myArray = new int[100];

            for (int j = 99; j >= 0; j--)
            {
                myArray[j] = j;
            }

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array,myArray);
        }

        [TestMethod]
        public void Sort_EvenElements_CorrectArray()
        {

            // arrange 
            int[] array = new[] { 1, 2, 3, 4, 5, 6 };
            int[] myArray = new[] { 2, 4, 3, 1, 6, 5 };

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);

        }

        [TestMethod]
        public void Sort_OddElements_CorrectArray()
        {

            // arrange 
            int[] array = new[] { 1, 2, 3, 4, 5  };
            int[] myArray = new[] { 2, 4, 3, 1, 5 };

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);

        }

        [TestMethod]
        public void Sort_TwoTheSameElem_CorrectArray()
        {

            // arrange 
            int[] array = new[] { 0, 0, 3, 4, 5, 6 };
            int[] myArray = new[] { 0, 4, 3, 0, 6, 5 };

            //act
            instance.Sort(myArray);

            //assert
            CollectionAssert.AreEqual(array, myArray);

        }


        [TestMethod]
        public void Sort_RandomNumberIntArray_CorrectArray()
        {

            // arrange 
            int[] myArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(10, 100);
            }
            //act
            instance.Sort(myArray);

            bool flag = true;

            for (int i = 0; i < myArray.Length-1; i++)
            {
                if (myArray[i] > myArray[i+1])
                {
                    flag = false;
                    break;
                }
            }

            //assert
            Assert.IsTrue(flag);
        }

    }
}
