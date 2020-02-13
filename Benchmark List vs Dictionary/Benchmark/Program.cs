using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Benchmark
{
    class Program
    {
        private static List<string> myList = new List<string>();
        private static Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Inserting:");
            Insert();
            Console.WriteLine();
            Console.WriteLine("Searching:");
            Search();
            Console.WriteLine();
            Console.WriteLine("Removing:");
            Remove();
        }

        static void Insert()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                myList.Add("String" + i);
            }
            sw.Stop();
            Console.WriteLine("List: {0}", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                myDictionary.Add(i, "String" + i);
            }
            sw.Stop();
            Console.WriteLine("Dictionary: {0}", sw.ElapsedTicks);
            sw.Reset();
        }

        static void Search()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            myList.Contains("String12345");
            sw.Stop();
            Console.WriteLine("List: {0}", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
            myDictionary.ContainsValue("String12345");
            sw.Stop();
            Console.WriteLine("Dictionary: {0}", sw.ElapsedTicks);
            sw.Reset();
        }

        static void Remove()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            myList.Remove("String12345");
            sw.Stop();
            Console.WriteLine("List: {0}", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
            myDictionary.Remove(12345);
            sw.Stop();
            Console.WriteLine("Dictionary: {0}", sw.ElapsedTicks);
            sw.Reset();
        }
    }
}
