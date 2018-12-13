using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansactionGalaxyGuide.Exceptions
{
    public class StrategyException : Exception
    {
        public StrategyException(string msg) : base(msg)
        {
        }
    }
}
