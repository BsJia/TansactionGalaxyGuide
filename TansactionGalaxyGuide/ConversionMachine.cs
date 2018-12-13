using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TansactionGalaxyGuide.Enums;

namespace TansactionGalaxyGuide
{
  public  class ConversionMachine
    {
        private static readonly object lockObj = new object();
        private ConversionMachine conversionMachine;
        private Dictionary<string, RomanNumberEnum> nameMapping = new Dictionary<string, RomanNumberEnum>();

        private ConversionMachine() { }
        public ConversionMachine Init()
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

    }
}
