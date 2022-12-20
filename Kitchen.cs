using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Kitchen
    {
        public abstract void CleanKitchen();
        public abstract void CookMeat();
        public virtual void CookSalad()
        {
            Console.WriteLine("Reja domati i krastavici");
        }
        public abstract void CookVegetarian();
    }
}
