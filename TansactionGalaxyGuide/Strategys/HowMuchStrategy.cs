using System.Linq;
using System.Text.RegularExpressions;
using TansactionGalaxyGuide.Models;

namespace TansactionGalaxyGuide.Strategys
{
    public class HowMuchStrategy : IInputStrategy
    {
        private readonly ConversionMachine _conversionMachine;
        private const string express = @"how much is(( \w+)+) ?";

        public HowMuchStrategy(ConversionMachine conversionMachine)
        {
            _conversionMachine = conversionMachine;
        }
        public string Exeute(string input)
        {
            var match = Regex.Match(input, express);

            var galaxyNumbers = match.Groups[1].Value.Trim();
            var galaxyNumbersList = galaxyNumbers.Trim().Split(' ');
            var romanLists = galaxyNumbersList.Select(n => _conversionMachine.GetNameMapping(n)).ToList();

            return $"{galaxyNumbers} is {RomanConverter.ToDecimal(romanLists)}";
        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, express);
            return match.Success;
        }
    }
}

