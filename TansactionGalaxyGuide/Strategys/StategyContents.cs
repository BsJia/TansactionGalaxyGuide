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
            inputStrategys = new IInputStrategy[]
            {
                new HowManyStategy(),
                new HowMuchStrategy(),
                new SetMapStrategy(),
                new SetPriceStrategy(),
            };
        }

        public string Exeute(string input)
        {
            var stategy = inputStrategys.FirstOrDefault(n => n.IsMatch(input));
            if (stategy == null)
            {
                throw new StrategyException("I have no idea what you are talking about");
            }
           return stategy.Exeute(input);
        }
    }
}
