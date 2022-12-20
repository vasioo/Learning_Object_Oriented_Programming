using System;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        public static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0]!="END")
            {
                Dough dough = new Dough(command[1], command[2], double.Parse(command[3]));
                Console.WriteLine(dough.ToString());
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
