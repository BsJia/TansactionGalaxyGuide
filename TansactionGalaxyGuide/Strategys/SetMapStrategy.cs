using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TansactionGalaxyGuide.Strategys
{
    public class SetMapStrategy : IInputStrategy
    {
        public string Exeute(string input)
        {
            throw new NotImplementedException();
        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, @"^(\w+) is ([I|V|X|L|C|D|M])$");
            return match.Success;
        }
    }
}
