using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class OldKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Old kitchen: Izhvyrli vs i izmii pepelta") ;
        }

        public override void CookMeat()
        {
            Console.WriteLine("Old kitchen: Sloji na ogunq i glei da ne se oparish");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Old kitchen: Nqma vegetarianci");
        }
    }
}
