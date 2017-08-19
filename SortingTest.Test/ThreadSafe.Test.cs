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

        private SortingArray<int> myInstance;


        [TestInitialize]
        public void Setup()
        {
            var array = new int[0];
            myInstance = new SortingArray<int>(array);
        }

        [TestMethod]
        public void ThreadingSafe_TwoThread_CorrectSorting()
        {
            //Arrange
            var actualArray = new int[10000];
            for (int i = 0; i > 10000; i++)
            {
                actualArray[i] = 10000 - i;
            }
            var expectedArray = new int[10000];
            for (int i = 0; i > 10000; i++)
            {
                expectedArray[i] = i + 1;
            }

            SortingArray<int> instance = new SortingArray<int>(actualArray);
            instance.Sorter = new QuickSorter<int>();


            //Act 
            Thread thread = new Thread(new ThreadStart(instance.Sort));
            thread.Start();
            instance.Sort();



            thread.Join();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void ThreadingSafe_TwoOperationInDifferentThread_CorrectArray()
        {
            //Arrange
            var t1 = new Thread(AddManyNumbers);
            var t2 = new Thread(AddManyNumbers);


            //Act
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


            //Assert
            Assert.AreEqual(20000, myInstance.Count);


        }
        private void AddManyNumbers()
        {
            for (int x = 0; x < 10000; x++)
            {
                myInstance.Add(x);
            }
        }
    }
}
