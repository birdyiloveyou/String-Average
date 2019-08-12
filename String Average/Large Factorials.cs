using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    [TestClass]
    public class LargeFactorialsTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            //Assert.AreEqual("1", LargeFactorials.Factorial(1));
            //Assert.AreEqual("120", LargeFactorials.Factorial(5));
            //Assert.AreEqual("362880", LargeFactorials.Factorial(9));
            Assert.AreEqual("1307674368000", LargeFactorials.Factorial(15));
        }
    }

    internal class LargeFactorials
    {
        public static string Factorial(int i)
        {
            if (i == 0)
                return "1";
            if (i == 1)
                return "1";
            if (i > 1)
                return Count(i, Factorial(i - 1));

            return null;
        }

        private static string Count(int i, string str)
        {
            var ans = new int[str.Length];
            for (var j = str.Length - 1; j >= 0; j--)
            {
                ans[j] += int.Parse(str[j].ToString()) * i;
                if (j != 0 && ans[j] >= 10)
                {
                    ans[j - 1] += ans[j] / 10;
                    ans[j] %= 10;
                }
            }

            var re = "";
            foreach (var a in ans)
            {
                re += a.ToString();
            }

            return re;
        }
    }
}