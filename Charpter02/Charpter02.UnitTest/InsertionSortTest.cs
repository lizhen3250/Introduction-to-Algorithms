using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Charpter02;

namespace Charpter02.UnitTest
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void TestMethodInsertionSort()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            int[] result = InsertionSort.Sort(arr);
            CollectionAssert.AreEqual(result, new int[] { 26, 31, 41, 41, 58, 59 });
        }

        [TestMethod]
        public void TestMethodInsertionSortByDescending()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            int[] result = InsertionSort.DescendingSort(arr);
            CollectionAssert.AreEqual(result, new int[] { 59, 58, 41, 41, 31, 26 });
        }

        [TestMethod]
        public void TestMethodLinearSearch()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            int result = InsertionSort.LinserSearch(arr, 41);
            Assert.AreEqual(result, 41);
        }

        [TestMethod]
        public void TestMethodBinarySearch()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            int result = InsertionSort.BinarySearch(arr, 41);
            Assert.AreEqual(result, 41);
        }

        [TestMethod]
        public void TestMethodBinarySearchRecursion()
        {
            int[] arr = { 31, 41, 59, 26, 41, 58 };
            int result = InsertionSort.BinarySearchRecursion(arr, 0, arr.Length - 1, 41);
            Assert.AreEqual(result, 41);
        }
    }
}
