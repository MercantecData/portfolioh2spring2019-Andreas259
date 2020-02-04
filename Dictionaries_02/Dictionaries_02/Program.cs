using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<float, bool> myDictionary = new Dictionary<float, bool>();

            myDictionary[4.2f] = true;
            myDictionary[3.2f] = false;
            myDictionary[2.1f] = true;
            myDictionary[1.1f] = false;
            myDictionary[1.7f] = false;
            myDictionary[7.1f] = true;
            myDictionary[7.2f] = true;
            myDictionary[4.3f] = false;
            myDictionary[4.9f] = false;
            myDictionary[8.1f] = true;
        }
    }
}
