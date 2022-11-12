using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class PrinterInherit : Printer
    {
        private Random random = new Random();
        public override void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
            base.Print(value);
        }
    }
}
