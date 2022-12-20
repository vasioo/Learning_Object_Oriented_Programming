using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> ListOfPeople { get; set; } = new List<Person>();
        public void AddMember(Person member)
        {
            ListOfPeople.Add(member);
        }
        public List<string> OverCertain()
        {
            List<string> list = new List<string>();
            ListOfPeople = ListOfPeople.OrderBy(x => x.Name).ToList();
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                if (ListOfPeople[i].Age > 30)
                {
                    list.Add($"{ListOfPeople[i].Name} - {ListOfPeople[i].Age}");
                }
            }
            return list;
        }
    }
}
