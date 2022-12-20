using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            foreach (var method in type.GetMethods())
            {
                object[] attrs = method.GetCustomAttributes(false);
                foreach (var attr in attrs)
                {
                    Author authorAttr = attr as Author;
                    if (authorAttr!=null)
                    {
                        Console.WriteLine($"{method.Name} is written by {authorAttr.Name}");
                    }
                }
            }
        }
    }
}
