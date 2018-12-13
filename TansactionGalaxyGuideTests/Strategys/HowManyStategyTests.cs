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
    public class HowManyStategyTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            var conversionMachine = ConversionMachine.Init();
            var howManyStategy = new HowManyStategy(conversionMachine);

            Assert.IsTrue(howManyStategy.IsMatch("how many Credits is glob prok Silver ?"));
            Assert.IsTrue(howManyStategy.IsMatch("how many Credits is glob prok Gold ?"));
            Assert.IsTrue(howManyStategy.IsMatch("how many Credits is glob prok Iron ?"));
            Assert.IsFalse(howManyStategy.IsMatch("how many Cts is glob prok Silver ?"));
        }
    }
}