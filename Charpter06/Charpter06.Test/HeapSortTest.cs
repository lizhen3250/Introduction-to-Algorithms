using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter06;

namespace Charpter06.Test
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void TestMethodMaxHeapify()
        {
            int[] nums = { 27, 16, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0};
            HeapSort.MaxHeapify(nums, 2, nums.Length - 1);
            CollectionAssert.AreEqual(nums, new int[] { 27, 16, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 });
        }

        [TestMethod]
        public void TestMethodBuildMaxHeap()
        {
            int[] nums = { 27, 16, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            HeapSort.BuildMaxHeap(nums);
            CollectionAssert.AreEqual(nums, new int[] { 27, 16, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 });
        }

        [TestMethod]
        public void TestMethodSort()
        {
            int[] nums = { 27, 16, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            HeapSort.Sort(nums);
            CollectionAssert.AreEqual(nums, new int[] { 0, 1, 3, 4, 5, 7, 8, 9, 10, 12, 13, 16, 16, 27 });
        }
    }
}
