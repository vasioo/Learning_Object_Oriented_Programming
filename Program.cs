using System;
using InterfacesAndAbstraction.Contracts;
namespace InterfacesAndAbstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            CareTaker care = new CareTaker();
            care.Feed(new Eagle());
            care.Feed(new Fish());
            care.Feed(new Crocodile());
            IFeedable feedable = new Lion();
        }
    }
}
