using System.Collections.Generic;
using TansactionGalaxyGuide.Enums;
using TansactionGalaxyGuide.Exceptions;

namespace TansactionGalaxyGuide
{
    public  class ConversionMachine
    {
        private static readonly object lockObj = new object();
        private static  ConversionMachine conversionMachine;
        private Dictionary<string, RomanNumberEnum> nameMapping = new Dictionary<string, RomanNumberEnum>();
        private Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>();

        private ConversionMachine() { }
        public static ConversionMachine Init()
        {
            if (conversionMachine == null)
            {
                lock (lockObj)
                {
                    if (conversionMachine == null)
                    {
                        conversionMachine = new ConversionMachine();
                    }
                }

            }
            return conversionMachine;
        }
        /// <summary>
        /// set  mapping
        /// </summary>
        /// <param name="name">  </param>
        /// <param name="romanNumberEnum"></param>
        public void SetNameMapping(string  name, RomanNumberEnum romanNumberEnum)
        {
            nameMapping.Add(name, romanNumberEnum);
        }
        /// <summary>
        /// get mapping
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public RomanNumberEnum GetNameMapping(string name)
        {
          var tryResult =  nameMapping.TryGetValue(name, out var romanNumberEnum);
           if (!tryResult) throw new ConversionMachineExceptions($"Without {name} mapping ");

            return romanNumberEnum;
        }
        /// <summary>
        /// setting  exchange rate
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rate"></param>
        public void SetExchangeRate(string name, decimal rate)
        {
            exchangeRates.Add(name, rate);
        }
        /// <summary>
        /// get exchange rate
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public decimal GetExchangeRate(string name)
        {
           var tryResult = exchangeRates.TryGetValue(name, out var exchangeRate);
            if (!tryResult) throw new ConversionMachineExceptions($"No {name} exchange rate was set");

            return exchangeRate;
        }


    }
}
