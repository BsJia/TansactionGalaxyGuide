using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TansactionGalaxyGuide.Strategys
{
    public class HowMuchStrategy : IInputStrategy
    {
        public string Exeute(string input)
        {
            throw new NotImplementedException();
        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, @"how much is(( \w+)+) ?");
            return match.Success;
        }
    }
}
