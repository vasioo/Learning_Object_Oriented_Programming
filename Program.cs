using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tire[] tires = new Tire[]
            {
                new Tire(1995,1.6),
                new Tire(1995,1.6),
                new Tire(1995,1.9),
                new Tire(1995,1.6),
            };
            Engine engine = new Engine(555, 3);
            Car defaultCar = new Car("BMW","X3",2006,10000,500,engine,tires);
            Console.WriteLine(defaultCar.WhoAmI());
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
