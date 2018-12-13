using System.Linq;
using System.Text.RegularExpressions;
using TansactionGalaxyGuide.Models;

namespace TansactionGalaxyGuide.Strategys
{
    public class HowManyStategy : IInputStrategy
    {
        private readonly ConversionMachine _conversionMachine;
        private const string express = @"how many Credits is ((\w+ )+)(\w+) ?";


        public HowManyStategy(ConversionMachine conversionMachine)
        {
            _conversionMachine = conversionMachine;
        }

        public string Exeute(string input)
        {

            var match = Regex.Match(input, express);
            var galaxyNumbers = match.Groups[1].Value.Trim();
            var galaxyNumbersList = galaxyNumbers.Split(' ');

            var romanLists = galaxyNumbersList.Select(n => _conversionMachine.GetNameMapping(n)).ToList();
            var rateName = match.Groups[3].Value;
            var rate = _conversionMachine.GetExchangeRate(rateName);
            var total = rate * RomanConverter.ToDecimal(romanLists);

            return $"{galaxyNumbers} {rateName} is {total.ToString("#0")} Credits";

           
        }

        public bool IsMatch(string input)
        {
            var match = Regex.Match(input, express);
            return match.Success;
        }
    }
}
