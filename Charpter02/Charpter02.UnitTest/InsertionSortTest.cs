﻿using System;
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
    }
}
