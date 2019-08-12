using System;
using System.Linq;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public class Ad
    {
        public static bool IsAnagram(string test, string original)
        {
            // your code goes here
            var groupA = test.ToUpper().GroupBy(x => x).OrderBy(y => y.Key);
            var groupB = original.ToUpper().GroupBy(y => y).OrderBy(y => y.Key);
            var a = groupB.ToExpectedObject().Equals(groupA);

            return a;
        }
    }

    [TestClass]
    public class AnagramDetection
    {
        [TestMethod]
        public void AnagramDetectionTest()
        {
            Assert.IsTrue(Ad.IsAnagram("Buckethead", "DeathCubeK"));
        }
    }
}