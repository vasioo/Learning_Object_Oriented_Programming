using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee
    {
        public Employee(int salary,int experience)
        {
            Salary = salary;
            Experience = experience;
        }
        public decimal Salary { get; set; }
        public int WorkHours { get; set; }
        public int Experience { get; set; }
    }
}
