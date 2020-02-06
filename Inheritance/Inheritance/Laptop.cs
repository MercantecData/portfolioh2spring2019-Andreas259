using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Laptop : Computer
    {
        bool battery;
        bool lidOpen;
        public Laptop(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }
        public void ChangeLidState()
        {
            if (!lidOpen)
            {
                Console.WriteLine("Lid is now open");
            }
            else
            {
                Console.WriteLine("Lid is now closed");
            }
        }
    }
}
