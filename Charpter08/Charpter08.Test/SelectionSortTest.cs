using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter08;

namespace Charpter08.Test
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void TestMethodSelectionSort()
        {
            int[] arr = { 38, 32, -1, 90, 3, 2, 5, 9, 7 };
            SelectionSort.Sort(ref arr);
            foreach (var i in arr)
                Console.WriteLine(i);
        }
    }
}
