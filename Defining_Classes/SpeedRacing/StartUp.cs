using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] write = Console.ReadLine().Split().ToArray();
                string model = write[0];
                double fuelAmount = double.Parse(write[1]);
                double fuelConsumption = double.Parse(write[2]);
                Car car = new Car
                    (model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] data = input.Split().ToArray();
                string model = data[1];
                double amountKm = double.Parse(data[2]);
                Car driving = cars.Where(car => car.Model == model).ToList().First();
                driving.CanIReachTheDistance(model, amountKm);
                input = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                Console.WriteLine
                    ($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}
