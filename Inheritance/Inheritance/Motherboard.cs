using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Motherboard
    {
        string type;
        string[] io = new string[] { "USB", "NIC" };

        public void Boot()
        {
            Console.WriteLine("Boot method was invoked");
        }
    }
}
