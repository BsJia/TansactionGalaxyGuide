using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TansactionGalaxyGuide.Exceptions;

namespace TansactionGalaxyGuide.Strategys
{
 public   class StategyContents
    {
        private IInputStrategy[] inputStrategys;
        public StategyContents()
        {
            var conversionMachine = ConversionMachine.Init();
            inputStrategys = new IInputStrategy[]
            {
                new HowManyStategy(conversionMachine),
                new HowMuchStrategy(conversionMachine),
                new SetMapStrategy(conversionMachine),
                new SetPriceStrategy(conversionMachine),
            };
        }

        public string Exeute(string input)
        {
            var stategy = inputStrategys.FirstOrDefault(n => n.IsMatch(input));
            if (stategy == null)
            {
                return "I have no idea what you are talking about";
            }
           return stategy.Exeute(input);
        }
    }
}
