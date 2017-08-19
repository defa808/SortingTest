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
            var actualArray = new int[] { 2, 4, 3, 1 };
            var expectedArray = new int[] { 1, 2, 3, 4 };

            SortingArray<int> instance = new SortingArray<int>(actualArray);
            instance.Sorter = new BubbleSorter<int>();


            //Act   
            Thread t = new Thread(new ThreadStart(instance.Sort));
            t.Start();
            instance.Sort();




            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void ThreadingSafe_TwoOperationInDifferentThread_CorrectArray()
        {
            //Arrange
            var expectedArray = new int[] { 1, 2, 3, 4, 1 };
            var actualArray = new int[] { 1, 2, 3, 4 };
            SortingArray<int> instance = new SortingArray<int>(actualArray);


            //Act
            Thread t = new Thread(new ThreadStart(instance.Sort));
            instance.Add(1);
            t.Start();
            instance.Add(1);


            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }
    }
}
