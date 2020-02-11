using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    public class Register
    {
        // Person list holds all persons.
        List<Person> persons = new List<Person>();
        // Add person.
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        // Remove person.
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
        // Get all persons.
        public List<Person> GetPersons()
        {
            return persons;
        }
    }
}
