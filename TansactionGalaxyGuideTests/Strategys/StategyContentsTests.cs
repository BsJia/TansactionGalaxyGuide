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
    public class StategyContentsTests
    {
        [TestMethod()]
        public void ExeuteTest()
        {
            var stategyContents = new StategyContents();

           stategyContents.Exeute("glob is I");
           stategyContents.Exeute("prok is V");
           stategyContents.Exeute("pish is X");
           stategyContents.Exeute("tegj is L");
           stategyContents.Exeute("glob glob Silver is 34 Credits");
           stategyContents.Exeute("glob prok Gold is 57800 Credits");
           stategyContents.Exeute("pish pish Iron is 3910 Credits");
            Assert.IsTrue( stategyContents.Exeute("how much is pish tegj glob glob ?")== "pish tegj glob glob is 42");
            Assert.IsTrue( stategyContents.Exeute("how many Credits is glob prok Silver?") == "glob prok Silver is 68 Credits");
            Assert.IsTrue( stategyContents.Exeute("how many Credits is glob prok Gold?") == "glob prok Gold is 57800 Credits");
            Assert.IsTrue( stategyContents.Exeute("how many Credits is glob prok Iron?") == "glob prok Iron is 782 Credits");
            Assert.IsTrue(stategyContents.Exeute("how much wood could a woodchuck chuck if a woodchuck could chuck wood ?") == "I have no idea what you are talking about");
        }
    }
}