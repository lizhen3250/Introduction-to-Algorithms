using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter04;

namespace Charpter04.Test
{
    [TestClass]
    public class SumOfMaximumSubArrayTest
    {
        [TestMethod]
        public void TestMethodSumOfMaximumSubArray()
        {
            int[] nums = { 1, 2, -1, -2, 4, 5, 6, 1 };
            int res = SumOfMaximumArray.MaximumSubArray(nums);
            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void TestMethodSumOfMaximumSubArrayWithDivdeAndConquer()
        {
            int[] nums = { 1, 2, -1, -2, 4, 5, 6, 1 };
            int res = SumOfMaximumArray.DivideMaxSubArray(nums);
            Assert.AreEqual(16, res);
        }
    }
}
