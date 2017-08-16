using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTest.Test
{
    [TestClass]
    public class InsertSortingArrayTests : SorterTest
    {

        protected override ISorter<T> GetInstance<T>()
        {
            return new InsertSorter<T>();
        }


    }
}
