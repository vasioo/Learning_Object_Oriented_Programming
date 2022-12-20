using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class NormalKitchen:Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Normal kitchen:  izmii spokoino");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Normal kitchen: sgotvi mesoto");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Normal kitchen: eto salata");
        }
    }
}
