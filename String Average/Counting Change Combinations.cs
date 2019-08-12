using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public class CountingChangeCombinations
    {
        public static int Count(int i, int[] ints)
        {
            Array.Sort(ints);

            return 0;
        }
    }

    [TestClass]
    public class CountingChangeCombinationsTest
    {
        [TestMethod]
        public void SimpleCase()
        {
            Assert.AreEqual(3, CountingChangeCombinations.Count(4, new[] { 1, 2 }));
        }
    }
}