using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(6,8);

            Intern intern = new Intern();
            intern.GetHelp();
            Employee employee;
            employee = new SoftwareEngineer();

           //((SoftwareEngineer)employee);
            SoftwareEngineer engineer = new SoftwareEngineer();
        }
    }
}
