using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar,IEelectricCar
    {
        public Tesla(string model,string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Battery { get ; set ; }
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
            return $"{Color} Tesla {Model}";
        }
    }
}
