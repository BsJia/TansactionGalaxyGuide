using Microsoft.VisualStudio.TestTools.UnitTesting;
using TansactionGalaxyGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TansactionGalaxyGuide.Enums;

namespace TansactionGalaxyGuide.Tests
{
    [TestClass()]
    public class ConversionMachineTests
    {
        private readonly ConversionMachine conversionMachine = ConversionMachine.Init();
        [TestMethod()]
        public void NameMappingTest()
        {
            var key = "asdf";
            conversionMachine.SetNameMapping(key, RomanNumberEnum.C);
            var nameMapping = conversionMachine.GetNameMapping(key);
            Assert.IsTrue(nameMapping.Equals(RomanNumberEnum.C));


        }

        [TestMethod()]
        public void ExchangeRateTest()
        {
            var key = "asdf";
            conversionMachine.SetExchangeRate(key, 12);
            var exchangeRate = conversionMachine.GetExchangeRate(key);
            Assert.IsTrue(exchangeRate == 12);
  
     
        }

        
    }
}