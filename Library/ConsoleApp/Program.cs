using System;
using Inheritance;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of desktop class.
            Desktop desktop = new Desktop("Asus", 3.4f, 8);
            desktop.ChangePowerState();

            // Create new instance of laptop class.
            Laptop laptop = new Laptop("Fujitsu", 3.2f, 4);
            laptop.ChangePowerState();

            // Create new instance of phone class.
            Phone phone = new Phone("Apple", 1.8f, 4);
            phone.ChangePowerState();
            phone.Call("+45 80808080");

            // Create new instance of smart watch class.
            SmartWatch smartWatch = new SmartWatch("Apple", 1.2f, 2);
            smartWatch.ChangePowerState();
            Console.WriteLine("Your puls is " + smartWatch.MeasurePuls());

            // Create new instance of tablet class.
            Tablet tablet = new Tablet("Apple", 2.1f, 4);
            tablet.ChangePowerState();
        }
    }
}
