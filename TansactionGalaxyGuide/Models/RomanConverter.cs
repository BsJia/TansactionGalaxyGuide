using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TansactionGalaxyGuide.Enums;

namespace TansactionGalaxyGuide.Models
{
  public  class RomanConverter
    {
      
        public static decimal ToDecimal(List<RomanNumberEnum> romanNumberEnums)
        {
            var current = 0M;
            var total = 0M;
            var next = 0M;

            for (int i = 0; i < romanNumberEnums.Count; i++)
            {
                current = (decimal)romanNumberEnums[i];
                if (i < romanNumberEnums.Count - 1)
                    next = (decimal)romanNumberEnums[i+1];

                if (current < next)
                {
                    total += next - current;
                    i++;
                }
                else
                {
                    total += current;
                }
            }

            return total;

        }
    }
}
