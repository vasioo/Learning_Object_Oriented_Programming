using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer3d = new ThreeDPrinter();
            Printer paperPrinter = new PaperPrinter();
            paperPrinter.Print();
        }
    }
}
