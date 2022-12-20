using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    abstract class Printer
    {
        public void Clean()
        {
            Console.WriteLine("Clean printer");
        }
        public abstract void Print();
        public int Size { get; set; }
        public int Color { get; set; }
    }
}
