using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class ThreeDPrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("printing in 3d");
        }
    }
}
