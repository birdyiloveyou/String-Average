using System;
using System.Text;
using System.Collections.Generic;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int x = 0, y = 0;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] != target) continue;
                    x = i;
                    y = j;
                }
            }

            return new[] { x, y };
        }
    }

    [TestClass]
    public class Two_Sum
    {
        [TestMethod]
        public void test()
        {
            var expected = new[] { 0, 1 };
            expected.ToExpectedObject().ShouldEqual(Solution.TwoSum(new[] { 2, 7, 11, 15 }, 9));
        }
    }
}