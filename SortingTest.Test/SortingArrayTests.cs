using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class SortingArrayTests: SorterTest
    {
        protected override ISorter<T> GetInstance<T>()
        {
            return new BubbleSorter<T>();
        }
    }
}
