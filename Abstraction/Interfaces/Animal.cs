using System;
using System.Collections.Generic;
using System.Text;
using InterfacesAndAbstraction.Contracts;
namespace InterfacesAndAbstraction
{
    public class Animal:IFeedable
    {
        public Animal(FoodType type, int doze)
        {
            FoodType = type;
            Doze = doze;
        }
        public FoodType FoodType { get; set; }
        public int Doze { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("I am eating...");
        }
        public void Sleep()
        {
            Console.WriteLine("Ï am sleeping");
        }
        public void Play()
        {
            Console.WriteLine("I am playing");
        }

        int IFeedable.Doze()
        {
            throw new NotImplementedException();
        }

        FoodType IFeedable.FoodType()
        {
            throw new NotImplementedException();
        }
    }
}
