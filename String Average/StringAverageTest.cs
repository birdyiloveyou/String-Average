using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public class Kata
    {
        public static string AverageString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "n/a";
            }

            var dic = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (var i = 0; i < dic.Length; i++)
            {
                str = str.Replace(dic[i], i.ToString());
            }
            var split = str.Split(' ');
            var nums = new int[split.Length];

            for (var i = 0; i < split.Length; i++)
            {
                try
                {
                    split[i] = split[i].Replace(",", "");
                    var num = int.Parse(split[i]);
                    nums[i] = num;
                }
                catch (Exception)
                {
                    return "n/a";
                }
            }

            var sum = (int)Math.Floor(nums.Average());

            if (sum >= 0 && sum <= 9)
                return dic[sum];
            return "n/a";
        }
    }

    [TestClass]
    public class StringAverageTest
    {
        [TestMethod]
        public void SampleTests()
        {
            Assert.AreEqual("four", Kata.AverageString("zero, nine, five two"));
            Assert.AreEqual("three", Kata.AverageString("four six two three"));
            Assert.AreEqual("three", Kata.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata.AverageString("five four"));
            Assert.AreEqual("zero", Kata.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata.AverageString(""));
            Assert.AreEqual("six", Kata.AverageString("eight, five"));
            Assert.AreEqual("six", Kata.AverageString("nine, one, nine, eight"));
        }
    }
}