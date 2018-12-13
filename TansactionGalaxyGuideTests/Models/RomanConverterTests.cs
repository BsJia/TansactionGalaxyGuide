using Microsoft.VisualStudio.TestTools.UnitTesting;
using TansactionGalaxyGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TansactionGalaxyGuide.Enums;

namespace TansactionGalaxyGuide.Models.Tests
{
    [TestClass()]
    public class RomanConverterTests
    {
        [TestMethod()]
        public void ToLongTest()
        {
            var list = new List<RomanNumberEnum>();
            list.Add(RomanNumberEnum.M);
            list.Add(RomanNumberEnum.M);
            list.Add(RomanNumberEnum.V);
            list.Add(RomanNumberEnum.I);
            var re = RomanConverter.ToDecimal(list);
            Assert.IsTrue( re == 2006);

            var list2 = new List<RomanNumberEnum>();
            list2.Add(RomanNumberEnum.M);
            list2.Add(RomanNumberEnum.C);
            list2.Add(RomanNumberEnum.M);
            list2.Add(RomanNumberEnum.X);
            list2.Add(RomanNumberEnum.L);
            list2.Add(RomanNumberEnum.I);
            list2.Add(RomanNumberEnum.V);
            var re2 = RomanConverter.ToDecimal(list2);
            Assert.IsTrue(re2 == 1944);

        }
    }
}