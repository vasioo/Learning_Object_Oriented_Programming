using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Mammal:Animal
    {
        public Mammal(int years):base(10)
        {
            Console.WriteLine("Mammal constructor");
        }
        public int EatAmount { get; set; }
        public void Eat()
        {
            Console.WriteLine("Mammal eating");
        }
        public void MammalEat(int EatAmount)
        {
            this.Eat();
            base.Eat();
        }

    }
}
