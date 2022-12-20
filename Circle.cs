using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeyWord
{
    class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle shape");
        }
        public int Radius { get; set; }
    }
}
