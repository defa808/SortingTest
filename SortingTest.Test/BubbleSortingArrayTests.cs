using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class BubbleSortingArrayTests: SorterTest
    {

        protected override ISorter<T> GetInstance<T>()
        {
            return new BubbleSorter<T>();
        }

       
    }
}
