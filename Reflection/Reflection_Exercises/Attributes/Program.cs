using System;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Id = 5,
                Model = "Top model",
                Name = "Seat Leon"

            };
            SerializeToJSON(product);
        }
        public static string SerializeToJSON<T>(T instance)
        {
            string result = "";
            Type type = typeof(T);

            PropertyInfo[] props = type.GetProperties();
            foreach (var prop in props)
            {
                Attribute serializableAttributes = prop.GetCustomAttribute(typeof(SerializableAttribute));
                if (serializableAttributes != null)
                {

                    Console.WriteLine($"{{{prop.Name}:{prop.GetValue(instance)}}}");
                }
            }

            return result;
        }
    }
    class Product
    {
        [SerializableAttribute(true)]
        public int Id { get; set; }
        [SerializableAttribute]
        public string Name { get; set; }
        [SerializableAttribute(true)]
        public string Model { get; set; }
        public int Quantity { get; set; }
        [SerializableAttribute]
        public bool IsFake { get; set; }
    }
    class SerializableAttribute : Attribute
    {
        public SerializableAttribute(bool isDeep)
        {
            IsDeep = IsDeep;
        }
        public SerializableAttribute() : this(false)
        {

        }
        public bool IsDeep { get; set; }
    }
}
