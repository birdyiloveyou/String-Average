using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public static class SumStringsAsNumbers
    {
        public static string ReverseArray(string arr)
        {
            var ans = "";
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                ans += arr[i].ToString();
            }

            return ans;
        }

        public static string SumStrings(string s1, string s2)
        {
            var a = ReverseArray(s1);
            var b = ReverseArray(s2);
            int[] c = null;
            c = a.Length > b.Length ? SumArray(a, b) : SumArray(b, a);

            var ans = "";
            for (var i = c.Length - 1; i >= 0; i--)
            {
                if (c[i] != 0 || i != c.Length - 1)
                {
                    ans += c[i];
                }
            }

            return ans;
        }

        private static int[] SumArray(string p1, string p2)
        {
            var ans = new int[p1.Length + 1];
            for (var i = 0; i < p2.Length; i++)
            {
                ans[i] += int.Parse(p1[i].ToString()) + int.Parse(p2[i].ToString());
                if (ans[i] < 10) continue;
                ans[i + 1] += 1;
                ans[i] %= 10;
            }

            for (var i = p2.Length; i < p1.Length; i++)
            {
                ans[i] += int.Parse(p1[i].ToString());
                if (ans[i] < 10) continue;
                ans[i + 1] += 1;
                ans[i] %= 10;
            }

            return ans;
        }
    }

    [TestClass]
    public class SumStringsAsNumbersTest

    {
        [TestMethod]
        public void Sample()
        {
            Assert.AreEqual("123004560", SumStringsAsNumbers.SumStrings("123000000", "4560"));
        }
    }
}