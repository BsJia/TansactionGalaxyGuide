using Microsoft.VisualStudio.TestTools.UnitTesting;
using TansactionGalaxyGuide.Strategys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansactionGalaxyGuide.Strategys.Tests
{
    [TestClass()]
    public class SetPriceStrategyTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
           var conversionMachine =  ConversionMachine.Init();
            var howManyStategy = new SetPriceStrategy(conversionMachine);

            Assert.IsTrue(howManyStategy.IsMatch("pish pish Iron is 3910 Credits"));
            Assert.IsTrue(howManyStategy.IsMatch("glob prok Gold is 57800 Credits"));
            Assert.IsFalse(howManyStategy.IsMatch("glob prok Gold is 5780dd0 Credits"));
            Assert.IsFalse(howManyStategy.IsMatch("glob prok Gold is 5780dd0 Cwredits"));
        }

    }
}