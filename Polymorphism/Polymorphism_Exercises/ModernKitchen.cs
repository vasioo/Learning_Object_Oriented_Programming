using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class ModernKitchen:Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Modern kitchen:  izmii spokoino");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Modern kitchen: sgotvi mesoto");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Modern kitchen: eto salata");
        }
        public override void CookSalad()
        {
            Console.WriteLine("Modern kitchen: gurme salata(nqma q)") ;
        }

        public virtual void RobotClean()
        {
            Console.WriteLine("Modern kitchen:  robotite shte ni prevzemat i izmiqt");
        }
    }
}
