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
            var expectedArray = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                expectedArray[i] = 5;
            }
            var actualArray = new int[0];
            SortingArray<int> instance = new SortingArray<int>(actualArray);

            //Act
            ParameterizedThreadStart Add = new ParameterizedThreadStart(Addd);
            Thread[] t = new Thread[10000];
            for (int i = 0; i < 10000; i++)
            {
                t[i] = new Thread(Add);
            }
            for (int i = 0; i < 10000; i++)
            {
                t[i].Start(instance);
            }


            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);


        }
        private void Addd(object a)
        {
            (a as SortingArray<int>).Add(5);
        }
    }
}
