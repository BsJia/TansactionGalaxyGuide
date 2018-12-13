using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TansactionGalaxyGuide.Enums;
using TansactionGalaxyGuide.Exceptions;

namespace TansactionGalaxyGuide.Strategys
{
    public class SetMapStrategy : IInputStrategy
    {
        private readonly ConversionMachine _conversionMachine;
        private const string express = @"^(\w+) is ([I|V|X|L|C|D|M])$";

        public SetMapStrategy(ConversionMachine conversionMachine)
        {
            _conversionMachine = conversionMachine;
        }
        public string Exeute(string input)
        {
            var match = Regex.Match(input, express);
            var galaxyNumber = match.Groups[1].Value;
            var romanNumber = match.Groups[2].Value;
            var tryResult = Enum.TryParse<RomanNumberEnum>(romanNumber, out var value);
            if (!tryResult)
            {
                throw new StrategyException("romanNumber parse error");
            }
            _conversionMachine.SetNameMapping(galaxyNumber, value);
            return string.Empty;

        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, express);
            return match.Success;
        }
    }
}
