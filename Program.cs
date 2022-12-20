using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Mammal mammal = new Mammal(5);
            mammal.MammalEat(5);
        }
    }
}
