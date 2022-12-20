using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeyWord
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle draw"); 
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
