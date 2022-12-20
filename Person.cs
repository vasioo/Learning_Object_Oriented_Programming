using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string  FirstName
            {
            get { return this.firstName; }
            set{this.firstName = value;}
            }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
        }
    }
}
