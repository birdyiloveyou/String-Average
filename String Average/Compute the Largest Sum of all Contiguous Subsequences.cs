using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public class ComputeTheLargestSumOfAllContiguousSubsequences
    {
        public static int Compute(int[] ints)
        {
            var max = 0;
            for (var i = 0; i < ints.Length; i++)
            {
                if (ints[i] <= 0)
                {
                    continue;
                }
                var sum = ints[i];
                for (var j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] >= 0)
                    {
                        sum += ints[j];
                        continue; ;
                    }

                    if (Check(j, ints))
                    {
                        sum += ints[j];
                        continue;
                    }

                    break;
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }

        private static bool Check(int i, int[] ints)
        {
            if (i == ints.Length - 1)
            {
                return false;
            }

            var max = ints[i];
            for (var j = i + 1; j < ints.Length; j++)
            {
                max += ints[j];
                if (max >= 0)
                {
                    return true;
                }
            }

            return false;
        }
    }

    [TestClass]
    public class ComputeTheLargestSumOfAllContiguousSubsequencesTest
    {
        [TestMethod]
        public void test_1234()
        {
            Assert.AreEqual(10, ComputeTheLargestSumOfAllContiguousSubsequences.Compute(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void test_187()
        {
            Assert.AreEqual(187, ComputeTheLargestSumOfAllContiguousSubsequences.Compute(new[] { 3, -4, 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 }));
        }

        [TestMethod]
        public void test_zero()
        {
            Assert.AreEqual(0, ComputeTheLargestSumOfAllContiguousSubsequences.Compute(new[] { -1, -2, -3 }));
        }
    }
}