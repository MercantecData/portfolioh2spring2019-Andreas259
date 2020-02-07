using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Desktop : Computer
    {
        bool psu;
        /// <summary>
        /// Initialize Desktop with manufacturer, CPU (MHz) and cores.
        /// </summary>
        /// <param name="manufacturer">Specify the desktop manufacturer</param>
        /// <param name="cpuMhz">Specify the desktop CPU (MHz)</param>
        /// <param name="cpuCores">Specify the desktop cores</param>
        public Desktop(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }
    }
}
