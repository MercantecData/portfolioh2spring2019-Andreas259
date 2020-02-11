using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    public class Person
    {
        // Variable firstName and lastName is private so you are forced to use the method GetFullName().
        private string firstName;
        private string lastName;
        public int age;
        public Vehicle[] Vehicles;
        // Constructor used to set general variables for a person.
        public Person(string firstName, string lastName, int age, Vehicle[] vehicles)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            Vehicles = vehicles;
        }
        // Get full name, returns first name combined with last name.
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
