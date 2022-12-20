using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Mouse:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Mouse eating");
            Food -= 1;
        }
    }
}
