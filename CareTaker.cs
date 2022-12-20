using System;
using System.Collections.Generic;
using System.Text;
using InterfacesAndAbstraction.Contracts;
namespace InterfacesAndAbstraction
{
    public class CareTaker
    {
        public void Feed(IFeedable feedable)
        {
            //Console.WriteLine(value: $"Get {feedable.Doze} { feedable.FoodType} from inventory");
            Console.WriteLine("Feeding animal");
            feedable.Eat();
        }
    }
}
