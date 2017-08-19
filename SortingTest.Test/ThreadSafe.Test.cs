using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingTest.Test
{

    [TestClass]
    public class ThreadSafe
    {

        [TestMethod]
        public void ThreadingSafe_TwoThread_CorrectSorting()
        {
            //Arrange
            var actualArray = new int[100000];
            for (int i = 0; i > 100000; i++)
            {
                actualArray[i] = 100000 - i;
            }
            var expectedArray = new int[100000];
            for (int i = 0; i > 100000; i++)
            {
                actualArray[i] = i + 1;
            }

            SortingArray<int> instance = new SortingArray<int>(actualArray);
            instance.Sorter = new BubbleSorter<int>();


            //Act 
            Thread thread = new Thread(new ThreadStart(instance.Sort));
            thread.Start();
            instance.Sort();




            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void ThreadingSafe_TwoOperationInDifferentThread_CorrectArray()
        {
            //Arrange
            var expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 11 };
            var actualArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            SortingArray<int> instance = new SortingArray<int>(actualArray);


            //Act
            ThreadStart removeLast = new ThreadStart(instance.RemoveLast);

            Thread thread = new Thread(removeLast);
            thread.Start();
            instance.Add(11);



            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }
    }
}
