using System;
using System.IO;

namespace GetInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(StreamWriter);
            Type[] interfaces = type.GetInterfaces();
            foreach (var interfaceType in interfaces)
            {
                Console.WriteLine(interfaceType.Name);
            }
        }
    }
}
