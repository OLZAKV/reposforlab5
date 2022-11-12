using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new PrinterInherit();
            for (int i = 0; i < 5; i++)
            {
                printer.Print(i.ToString());
            }
        }
    }
}
