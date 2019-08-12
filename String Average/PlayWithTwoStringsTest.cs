using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public static class PlayWithTwoStrings

    {
        public static string WorkOnStrings(string s1, string s2)
        {
            return Change(s1, s2) + Change(s2, s1);
        }

        private static string Change(string s1, string s2)
        {
            foreach (var c2 in s2)
            {
                var newS1 = "";
                foreach (var c1 in s1)
                {
                    newS1 += string.Equals(c1.ToString(), c2.ToString(), StringComparison.OrdinalIgnoreCase) ? (char.IsUpper(c1) ? c1.ToString().ToLower() : c1.ToString().ToUpper()) : c1.ToString();
                }

                s1 = newS1;
            }

            return s1;
        }
    }

    [TestClass]
    public class PlayWithTwoStringsTest
    {
        [TestMethod]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("abCCde", PlayWithTwoStrings.WorkOnStrings("abc", "cde"));
        }

        [TestMethod]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("ABABbababa", PlayWithTwoStrings.WorkOnStrings("abab", "bababa"));
        }

        [TestMethod]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", PlayWithTwoStrings.WorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe"));
        }

        [TestMethod]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual("abcDEfgDEFGg", PlayWithTwoStrings.WorkOnStrings("abcdeFg", "defgG"));
        }
    }
}