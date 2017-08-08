using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class QuickSortingArrayTests : SorterTest
    {

        protected override ISorter<T> GetInstance<T>()
        {
            return new QuickSorter<T>();
        }


    }
}
