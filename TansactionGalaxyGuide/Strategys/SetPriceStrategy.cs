using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TansactionGalaxyGuide.Models;

namespace TansactionGalaxyGuide.Strategys
{
    public class SetPriceStrategy : IInputStrategy
    {
        private readonly ConversionMachine _conversionMachine;
        private const string express = @"((\w+ )+)(\w+) is (\d+) Credits";

        public SetPriceStrategy(ConversionMachine conversionMachine)
        {
            _conversionMachine = conversionMachine;
        }
        public string Exeute(string input)
        {
            var match = Regex.Match(input, express);
            var galaxyNumbers = match.Groups[1].Value;
            var galaxyNumbersList= galaxyNumbers.Trim().Split(' ');
            var romanLists= galaxyNumbersList.Select(n => _conversionMachine.GetNameMapping(n)).ToList();

            var rate = long.Parse(match.Groups[4].Value) / RomanConverter.ToDecimal(romanLists);
            var name = match.Groups[3].Value;
            _conversionMachine.SetExchangeRate(match.Groups[3].Value, rate);
            return string.Empty;
        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, express);
            return match.Success;
        }
    }
}
