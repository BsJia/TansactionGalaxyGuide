using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TansactionGalaxyGuide.Strategys;

namespace TansactionGalaxyGuideConsole
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walcome  to Galaxy, Please write each line of code!");
            var stategyContents = new StategyContents();
            string readLine;
            readLine = Console.ReadLine();

            var writeSb = new StringBuilder() ;
            while (!string.IsNullOrEmpty(readLine))
            {
                string exeResult = string.Empty;
                try
                {
                    exeResult = stategyContents.Exeute(readLine);
                }
                catch (Exception e)
                {
                    writeSb.Append(e.Message);
                    writeSb.Append("\n");
                }

                if (!string.IsNullOrEmpty(exeResult))
                {
                    writeSb.Append(exeResult);
                    writeSb.Append("\n");
                }
                readLine = Console.ReadLine();
            }

            Console.WriteLine(writeSb.ToString());
            Console.ReadLine();





        }
    }
}
