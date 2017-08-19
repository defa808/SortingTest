using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest.Test
{
	[TestClass]
    public class RemoveLast
    {
        [TestMethod]
        public void RemoveLast_IntElement_CorrectArray()
        {
            //Arrange
            var expectedArray = new int[] { 1, 2};
            var actualArray = new int[] { 1, 2, 3 };
            SortingArray<int> instance = new SortingArray<int>(actualArray);


            //Act
            instance.RemoveLast();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void RemoveLast_StringElement_CorrectArray()
        {
            //Arrange
            var expectedArray = new string[] { "a","b" };
            var actualArray = new string[] { "a", "b", "c" };
            SortingArray<string> instance = new SortingArray<string>(actualArray);


            //Act
            instance.RemoveLast();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void RemoveLast_RemoveNull_CorrectArray()
        {
            //Arrange
            var expectedArray = new string[] { "a", "b" };
            var actualArray = new string[] { "a", "b", null };
            SortingArray<string> instance = new SortingArray<string>(actualArray);


            //Act
            instance.RemoveLast();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

        [TestMethod]
        public void RemoveLast_RemoveBeforeNull_CorrectArray()
        {
            //Arrange
            var expectedArray = new string[] { "a", null };
            var actualArray = new string[] { "a", null, "b" };
            SortingArray<string> instance = new SortingArray<string>(actualArray);


            //Act
            instance.RemoveLast();

            //Assert
            CollectionAssert.AreEqual(expectedArray, instance.CollectionArray);

        }

    }
}
