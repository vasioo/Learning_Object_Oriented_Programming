using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            ; this.radius = radius;
        }
        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rout = this.radius + 0.4;
            for (double y = this.radius; y >= -this.radius; --y)
            {
                for (double x = -this.radius; x < rout; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rout * rout)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
