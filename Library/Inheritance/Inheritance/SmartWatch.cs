using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class SmartWatch : Computer
    {
        bool battery;
        public SmartWatch(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }
        public int MeasurePuls()
        {
            Random random = new Random();
            return random.Next(40, 200);
        }
    }
}
