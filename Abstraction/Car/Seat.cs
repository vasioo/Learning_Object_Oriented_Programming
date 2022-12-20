using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Color { get; set; }
        public string Model { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return $"Break!!!!!!";
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
