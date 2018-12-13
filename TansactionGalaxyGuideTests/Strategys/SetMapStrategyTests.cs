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
    public class SetMapStrategyTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            var conversionMachine = ConversionMachine.Init();
            var howManyStategy = new SetMapStrategy(conversionMachine);

            Assert.IsTrue(howManyStategy.IsMatch("glob is I"));
            Assert.IsTrue(howManyStategy.IsMatch("prok is V"));
            Assert.IsTrue(howManyStategy.IsMatch("pish is X"));
            Assert.IsFalse(howManyStategy.IsMatch("pish pish is X"));
        }
    }
}