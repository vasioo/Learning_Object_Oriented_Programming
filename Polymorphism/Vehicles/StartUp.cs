using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Car car = new Car(double.Parse(input[1]), double.Parse(input[2]),double.Parse(input[3]));

            string[] secondInput = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(secondInput[1]), double.Parse(secondInput[2]), double.Parse(secondInput[3]));
            
            string[] thirdInput = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(thirdInput[1]), double.Parse(thirdInput[2]),double.Parse(thirdInput[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                 if (command[0] == "Drive")
                {
                    switch (command[1])
                    {
                        case "Car":
                            Console.WriteLine(car.Drive(double.Parse(command[2])));
                            break;
                        case "Truck":
                            Console.WriteLine(truck.Drive(double.Parse(command[2])));
                            break;
                        case "Bus":
                            Console.WriteLine(bus.Drive(command[0],double.Parse(command[2])));
                            break;
                        default:
                            break;
                    }
                }
                else if (command[0] == "Refuel")
                {
                    switch (command[1])
                    {
                        case "Car":
                            car.Refuel(double.Parse(command[2]));
                            break;
                        case "Truck":
                            truck.Refuel(double.Parse(command[2]));
                            break;
                        case "Bus":
                            bus.Refuel(double.Parse(command[2]));
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:0.00}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:0.00}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:0.00}");
        }
    }
}
