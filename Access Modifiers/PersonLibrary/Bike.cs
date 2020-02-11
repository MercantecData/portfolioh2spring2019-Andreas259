using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    // Bike class is a sub class of vehicle.
    public class Bike : Vehicle
    {
        public Bike(string brand, string color, int wheels = 2) : base(brand, color, wheels)
        {
        }
    }
}
