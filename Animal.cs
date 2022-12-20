using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    public class Animal
    {
        public int Food { get; set; }
        public Animal()
        {
            Food = 100;
        }
        public virtual void Eat()
        {
            Console.WriteLine("Animal eating");
            Food -= 25;
        }
    }
}
