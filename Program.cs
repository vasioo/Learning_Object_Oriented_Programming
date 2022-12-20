using System;
using System.Reflection;

namespace ActivatorCreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string typeToCreate = Console.ReadLine();
            Type type = typeof(Student); //Type.GetType(typeToCreate);
            object instance = (Student)Activator.CreateInstance(type, "uahhs");
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"field.Name - {field.Name}");
                Console.WriteLine($"field.Value - {field.GetValue(instance)}");
                Console.WriteLine($"field.IsStatic - {field.IsStatic}");
                Console.WriteLine($"field.FieldType - {field.FieldType}");
                Console.WriteLine($"field.IsPublic - {field.IsPublic}");
                Console.WriteLine($"field.IsFamily - {field.IsFamily}");
                Console.WriteLine($"field.IsPrivate - {field.IsPrivate}");
            }
        }
    }
    class Student
    {
        private string name;
        private static string cheatingCodes = "42,355";
        public Student(string name)
        {
            this.name = name;
        }

    }
}
