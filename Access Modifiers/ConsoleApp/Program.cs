using System;
using System.Collections.Generic;
using System.Linq;
using PersonLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();
            var person1 = new Person("Andreas", "Madsen", 25, new Vehicle[] { new Car("Skoda", "Black"), new Bike("Trek", "Blue") });
            register.AddPerson(person1);
            var person2 = new Person("Bo", "Rasmussen", 34, new Vehicle[] { new Car("Audi", "Grey"), new Bike("Shimano", "Red") });
            register.AddPerson(person2);
            register.RemovePerson(person2);

            List<Person> persons = register.GetPersons();
            foreach (var item in persons)
            {
                Console.WriteLine("Name: {0} Age: {1}", item.GetFullName(), item.age);
                foreach (var vehicle in item.Vehicles)
                {

                    Console.WriteLine(vehicle.GetVehicle());
                }
            }
        }
    }
}
