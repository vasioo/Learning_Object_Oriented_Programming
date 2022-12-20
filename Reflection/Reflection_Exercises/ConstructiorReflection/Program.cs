using System;
using System.Reflection;
using System.Text;

namespace ConstructorReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                Console.WriteLine($"Constructor with {parameters.Length} count of params");
                foreach (var parameter in parameters)
                {
                    Console.WriteLine(parameter.ParameterType+" ");
                    Console.WriteLine(parameter.Name);
                }
                Console.WriteLine();
            }
            Student student = (Student)constructors[2].Invoke(new object[] { });
            student.Hi();
        }
    }
    class Student
    {
        private string name;
        private int x;
        private static string cheatinBuddy = "Dimitrichka";
        private string cheatingCodes = "42, 355";
        public Student(string name, int x, int y, StringBuilder text)
        {
            Console.WriteLine("Setting name in the constructor "+name);
            this.name = name;
        }
        public Student()
        {
            Console.WriteLine("Prazen konstruktor");
        }
        public void Hi()
        {
            Console.WriteLine("opala"+name);
        }
    }
}
