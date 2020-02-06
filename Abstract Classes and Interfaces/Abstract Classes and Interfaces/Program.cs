using System;
using System.Collections.Generic;

namespace AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Class
            Console.WriteLine("Verify Abstract Class:");
            new SubClass1().Start();
            new SubClass2().Start();
            new SubClass3().Start();

            // Interfaces
            Console.WriteLine("Verify Interfaces:");
            Console.WriteLine("Interface Class 1");
            new InterfaceClass1();
            Console.WriteLine("Interface Class 2");
            new InterfaceClass2();

            // Build list and sort it with IComparable
            var personList = new List<Person>();
            personList.Add(new Person() { name = "Andreas", age = 25, gender = "Male" });
            personList.Add(new Person() { name = "Jesper", age = 31, gender = "Male" });
            personList.Add(new Person() { name = "Louise", age = 11, gender = "Female" });
            personList.Add(new Person() { name = "Kenneth", age = 25, gender = "Female" });
            personList.Add(new Person() { name = "Lone", age = 42, gender = "Female" });
            personList.Add(new Person() { name = "Rasmus", age = 37, gender = "Male" });
            personList.Add(new Person() { name = "Thomas", age = 29, gender = "Male" });
            personList.Add(new Person() { name = "Anja", age = 52, gender = "Female" });
            personList.Add(new Person() { name = "Charlotte", age = 43, gender = "Female" });
            personList.Add(new Person() { name = "Uffe", age = 51, gender = "Male" });

            personList.Sort();

            foreach (var person in personList)
            {
                Console.WriteLine("Name: {0} Age: {1} Gender: {2}", person.name, person.age, person.gender);
            }
        }
    }
}
