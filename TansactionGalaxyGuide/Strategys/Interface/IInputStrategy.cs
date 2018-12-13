using System;
using System.Collections.Generic;
using System.Text;

namespace TansactionGalaxyGuide.Strategys
{
    public interface IInputStrategy
    {
        bool IsMatch(string input);
        string Exeute(string input);
    }
}




