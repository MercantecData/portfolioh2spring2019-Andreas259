using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    class Person : IComparable<Person>
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public int CompareTo(Person item)
        {
            // Sort by age [High to low]
            // return item.age.CompareTo(age);
            // Sort by age [Low to high]
            //return age.CompareTo(item.age);

            // Sort by age [Low to high] if names is equal
            if (item.name == name)
            {
                if (item.age == age)
                {
                    return gender.CompareTo(item.gender);
                }
                return age.CompareTo(item.age);
            }
            // Alphabetic sort [A-Z]
            return name.CompareTo(item.name);
        }
    }
}
