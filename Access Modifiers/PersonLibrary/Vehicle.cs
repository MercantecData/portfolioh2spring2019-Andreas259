using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    // Vehicle class is abstract so you can't create a instance of it.
    public abstract class Vehicle
    {
        // Variables is protected so there are only accessible in current class and classes inherit from it.
        protected string brand;
        protected string color;
        protected int wheels;
        // Constructor used to set general variables for a vehicle. 
        public Vehicle(string brand, string color, int wheels)
        {
            this.brand = brand;
            this.color = color;
            this.wheels = wheels;
        }
        // Get informations for a vehicle.
        public string GetVehicle()
        {
            return Helper.TypeOfVehicle(wheels) + " | Brand: " + brand + " Color: " + color;
        }
    }
}
