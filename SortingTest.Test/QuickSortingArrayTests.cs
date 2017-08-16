using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class QuickSortingArrayTests : SortTest
    {

        protected override ISorter<T> GetInstance<T>()
        {
            return new QuickSorter<T>();
        }


    }
}
