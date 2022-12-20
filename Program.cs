using Mocking_And_TDD.IRepository;
using System;

namespace Mocking_And_TDD
{
    class Program
    {
        static void Main(string[] args)
        {

            BankTextDB database = new BankTextDB();
            Bank bank = new Bank(database, new TimeHelper());
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "new")
                {
                    Console.WriteLine("Name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Amount?");
                    int amount = int.Parse(Console.ReadLine());

                    User newUser = new User()
                    {
                        Name = name,
                        Account = new Account()
                        {
                            Amount = amount
                        }
                    };
                    bank.AddUser(newUser);
                }
                if (command=="transfer")
                {
                    string from = Console.ReadLine();
                    string to = Console.ReadLine();
                    int amount = int.Parse(Console.ReadLine());
                    bank.TransferMoney(from, to, amount);
                }
                if (command == "list")
                {
                    foreach (var user in bank.Users)
                    {
                        Console.WriteLine(user);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
