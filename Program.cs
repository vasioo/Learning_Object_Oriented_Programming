using System;

namespace IsKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            if (new Random().Next()%2==0)
            {
                shape = new Circle();
            }
            else
            {
                shape = new Rectangle();
            }
            //Rectangle rec = shape as Rectangle;
            //Circle cir = shape as Circle;
            shape.Draw();
            if (shape is Circle)
            {
               int radius = ((Circle)shape).Radius;
                Console.WriteLine($"Radius: {radius}");
            }
        }
    }
}
