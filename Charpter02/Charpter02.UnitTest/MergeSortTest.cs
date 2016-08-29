using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter02;

namespace Charpter02.UnitTest
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void MergeSort()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            MergeSortAlgorithm.Merge(arr, 0, arr.Length);
            CollectionAssert.AreEqual(arr, new int[] { 26, 31, 41, 41, 58, 59 });
        }
    }
}
