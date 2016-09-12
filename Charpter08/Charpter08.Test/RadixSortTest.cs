using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter08;

namespace Charpter08.Test
{
    [TestClass]
    public class RadixSortTest
    {
        [TestMethod]
        public void TestMethodRadixSort()
        {
            int[] arr = { 239, 457, 657, 839, 436, 720, 355, 10, 2, 20, 1000 };
            RadixSort.Sort(ref arr);
            CollectionAssert.AreEqual(arr, new int[] { 2, 10, 20, 239, 355, 436, 457, 657, 720, 839, 1000 });
        }
    }
}
