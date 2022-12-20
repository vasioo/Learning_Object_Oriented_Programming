﻿using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            Elephant elephant = new Elephant();

            Eat(mouse);
            Eat(elephant);
        }
        public static void Eat(Animal animal)
        {
            animal.Eat();
            Console.WriteLine(animal.Food);
        }
    }
}
