using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Dog : Mammal
    {
        public Dog():base(5)
        {
            Console.WriteLine("Dog constructor");
        }
    }
}
