using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter07;

namespace Charpter07.Test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void TestMethodQuickSort()
        {
            int[] nums = { 31, 46, 92, 48, 52, 2, 1, 4 };
            QuickSort.Sort(nums, 0, nums.Length - 1);
            foreach (var i in nums)
                Console.WriteLine(i);
        }
    }
}
