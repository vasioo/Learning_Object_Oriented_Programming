using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        string Start();
        string Stop();
        string Color { get; set; }
        string Model { get; set; }
    }
}
