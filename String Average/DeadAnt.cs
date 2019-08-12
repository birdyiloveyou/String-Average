using System.Linq;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Average
{
    public class DeadAnt
    {
        public static int DeadAntCount(string ants)
        {
            ants = ants?.Replace("ant", "");
            if (string.IsNullOrWhiteSpace(ants))
            {
                return 0;
            }
            var group = ants.Where(x => x == 'a' || x == 'n' || x == 't').GroupBy(y => y).Select(y => y.Count()).Max();
            return group;
        }
    }

    [TestClass]
    public class DeadAntTest
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual(0, DeadAnt.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, DeadAnt.DeadAntCount(null));
            Assert.AreEqual(2, DeadAnt.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAnt.DeadAntCount("ant ant .... a nt"));
        }

        [TestMethod]
        public void one_dead_ant_t()
        {
            Assert.AreEqual(1, DeadAnt.DeadAntCount("t"));
        }

        [TestMethod]
        public void two_dead_ants_nnt()
        {
            Assert.AreEqual(2, DeadAnt.DeadAntCount("nnt"));
        }

        [TestMethod]
        public void two_dead_ants_t()
        {
            Assert.AreEqual(2, DeadAnt.DeadAntCount("tt"));
        }

        [TestMethod]
        public void two_dead_ants_with_live_ant()
        {
            Assert.AreEqual(2, DeadAnt.DeadAntCount("nt antnt"));
        }
    }
}