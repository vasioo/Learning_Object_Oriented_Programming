using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class RobotKitchen:ModernKitchen
    {
        public override void CookMeat()
        {
            Console.WriteLine("Modern kitchen: nai pravilno sgotvenoto meso");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Robot kitchen: eto salata");
        }
        public override void CookSalad()
        {
            Console.WriteLine("Robot kitchen: gurme salata(nqma q) ama nqa i kosmi");
        }

        public override void RobotClean()
        {
            Console.WriteLine("Robot kitchen:  robotite shte ni prevzemat i izmiqt");
        }
    }
}
