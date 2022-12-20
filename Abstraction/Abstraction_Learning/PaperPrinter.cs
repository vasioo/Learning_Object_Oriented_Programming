using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class PaperPrinter:Printer
    {
        public override void Print()
        {
            Console.WriteLine("Printing to paper") ;
        }
    }
}
