using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter08;

namespace Charpter08.Test
{
    [TestClass]
    public class CountingSortTest
    {
        [TestMethod]
        public void TestMethodCountingSort()
        {
            int[] arr = { 2, 5, 6, 1, 3, 2, 4, 10, 50 };
            int[] res = CountingSort.Sort(arr);
            CollectionAssert.AreEqual(res, new int[] { 1, 2, 2, 3, 4, 5, 6, 10, 50 });
        }
    }
}
