using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sweepstakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.Tests
{
    [TestClass()]
    public class SweepstakesTests
    {
        [TestMethod()]
        public void RegisterContestantTest()
        {
            Sweepstakes testSweep = new Sweepstakes("Test");
            Contestant contestant1 = new Contestant("Ryan Webb", 25, "3145917157", "me@aol.com");
            Contestant contestant2 = new Contestant("Dave Gold", 29, "4148705309", "fake@gmail.com");
            Contestant contestant3 = new Contestant("Frank Jun", 33, "3214587689", "morefake@yahoo.com");
            testSweep.RegisterContestant(contestant1);
            testSweep.RegisterContestant(contestant2);
            testSweep.RegisterContestant(contestant3);

            Assert.IsTrue(testSweep.sweepstakes.ContainsValue(contestant1));
            Assert.AreNotEqual(contestant1, contestant2);
        }
    }
}