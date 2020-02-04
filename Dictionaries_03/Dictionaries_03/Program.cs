using System;
using System.Collections.Generic;

namespace Dictionaries_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person, bool> myDictionary = new Dictionary<Person, bool>();

            myDictionary[new Person() { Name = "Andreas" }] = true;
            myDictionary[new Person() { Age = 19 }] = false;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
