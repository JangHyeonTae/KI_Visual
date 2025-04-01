using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game
{
    internal class Util
    {
        public static void Print(string context, ConsoleColor textCOlor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textCOlor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
