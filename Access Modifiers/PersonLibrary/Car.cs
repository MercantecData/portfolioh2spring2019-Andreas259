using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    // Car class is a sub class of vehicle.
    public class Car : Vehicle
    {
        public Car(string brand, string color, int wheels = 4) : base(brand, color, wheels)
        {
        }
    }
}
