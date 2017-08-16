using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class BubbleSortingArrayTests: SortTest
    {

        protected override ISorter<T> GetInstance<T>()
        {
            return new BubbleSorter<T>();
        }

       
    }
}
