using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    public class Crocodile : Animal
    {
        public Crocodile() : base(FoodType.Meat, 5) { }
        public override void Eat()
        {
            Console.WriteLine("Eating everything");
        }
        public void ScarePeople()
        {
            Console.WriteLine("Pa");
        }
    }
}
