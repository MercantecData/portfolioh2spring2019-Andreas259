using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Phone : Computer
    {
        bool battery;
        public Phone(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }
        public void Call(string number)
        {
            Console.WriteLine("Phone is now ringing to " + number);
        }
    }
}
