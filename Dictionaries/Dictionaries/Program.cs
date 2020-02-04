using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary 1");
            Dictionary<string, int> dictionary1 = Dictionary1();

            foreach (var item in dictionary1)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            Console.WriteLine("Dictionary 2");
            Dictionary<float, bool> dictionary2 = Dictionary2();

            foreach (var item in dictionary2)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            Console.WriteLine("Dictionary 3 (Bonus)");
            Dictionary<Person, bool> dictionary3 = Dictionary3();

            foreach (var item in dictionary3)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
        }

        public static Dictionary<string, int> Dictionary1()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary["Adam"] = 37;
            dictionary["Anders"] = 41;
            dictionary["Andreas"] = 25;
            dictionary["Bo"] = 31;
            dictionary["Benjamin"] = 35;
            dictionary["Casper"] = 52;
            dictionary["David"] = 32;
            dictionary["Rasmus"] = 34;
            dictionary["Samuel"] = 39;
            dictionary["Sebastian"] = 27;

            return dictionary;
        }

        public static Dictionary<float, bool> Dictionary2()
        {
            Dictionary<float, bool> dictionary = new Dictionary<float, bool>();

            dictionary[4.2f] = true;
            dictionary[3.2f] = false;
            dictionary[2.1f] = true;
            dictionary[1.1f] = false;
            dictionary[1.7f] = false;
            dictionary[7.1f] = true;
            dictionary[7.2f] = true;
            dictionary[4.3f] = false;
            dictionary[4.9f] = false;
            dictionary[8.1f] = true;

            return dictionary;
        }

        public static Dictionary<Person, bool> Dictionary3()
        {
            Dictionary<Person, bool> dictionary = new Dictionary<Person, bool>();

            dictionary[new Person() { Name = "Andreas" }] = true;
            dictionary[new Person() { Age = 17 }] = false;

            return dictionary;
        }
    }
}
