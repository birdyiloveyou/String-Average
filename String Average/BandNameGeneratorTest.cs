using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public static class BandNameGenerator
    {
        public static string Generator(string word)
        {
            return word[0] == word[word.Length - 1] ? word[0].ToString().ToUpper() + word.Substring(1) + word.Substring(1) : "The " + word[0].ToString().ToUpper() + word.Remove(0, 1);
        }
    }

    [TestClass]
    public class BandNameGeneratorTest
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("The Knife", BandNameGenerator.Generator("knife"));
            Assert.AreEqual("Tartart", BandNameGenerator.Generator("tart"));
            Assert.AreEqual("Sandlesandles", BandNameGenerator.Generator("sandles"));
            Assert.AreEqual("The Bed", BandNameGenerator.Generator("bed"));
        }

        [TestMethod]
        public void should_output_sandlesandles()
        {
            Assert.AreEqual("Sandlesandles", BandNameGenerator.Generator("sandles"));
        }

        [TestMethod]
        public void should_output_the_knife()
        {
            Assert.AreEqual("The Knife", BandNameGenerator.Generator("knife"));
        }
    }
}