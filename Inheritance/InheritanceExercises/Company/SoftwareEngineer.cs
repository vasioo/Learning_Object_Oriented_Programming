using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class SoftwareEngineer : Employee
    {
        public SoftwareEngineer(int salary,int experience):base(Employee)
        {

        }
        public Laptop Laptop { get; set; }
        public void Program()
        {
            Console.WriteLine("Doing nothing all day!");
        }
    }
}
