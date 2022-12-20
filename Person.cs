using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises
{
    public class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));
            return stringBuilder.ToString();
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
