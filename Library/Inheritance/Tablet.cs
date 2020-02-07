using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Tablet : Computer
    {
        bool battery;
        public Tablet(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }
    }
}
