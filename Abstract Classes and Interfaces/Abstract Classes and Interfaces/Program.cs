using System;

namespace AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Class
            Console.WriteLine("Verify Abstract Class:");
            new SubClass1().Start();
            new SubClass2().Start();
            new SubClass3().Start();

            // Interfaces
            Console.WriteLine("Verify Interfaces:");
            Console.WriteLine("Interface Class 1");
            new InterfaceClass1();
            Console.WriteLine("Interface Class 2");
            new InterfaceClass2();
        }
    }
}
