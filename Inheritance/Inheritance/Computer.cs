using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Computer
    {
        string manufacturer;
        Motherboard motherboard;
        CPU cpu;
        bool poweredOn;

        public Computer(string manufacturer, float cpuMhz, int cpuCores)
        {
            this.manufacturer = manufacturer;
            motherboard = new Motherboard();
            cpu = new CPU(cpuMhz, cpuCores);
        }

        public void ChangePowerState()
        {
            if (!poweredOn)
            {
                Console.WriteLine("Computer of manufacturer " + manufacturer + " is powered on");
                poweredOn = true;
                motherboard.Boot();
            }
            else
            {
                Console.WriteLine("Computer of manufacturer " + manufacturer + " is powered off");
                poweredOn = false;
            }
        }
    }
}
