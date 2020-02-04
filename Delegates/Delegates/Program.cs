using System;

namespace Delegates
{
    class Program
    {
        public delegate void method1Delegate();
        public delegate float method2Delegate();
        public delegate void method3Delegate(string name, int age, float height);
        static void Main(string[] args)
        {
            // Point delegate1 to Method1
            method1Delegate delegate1 = Method1;
            delegate1();

            // Point delegate2 to Method2
            method2Delegate delegate2 = Method2;
            Console.WriteLine("Method 2 float value " + delegate2());

            // Point delegate3 to Method3
            method3Delegate delegate3 = Method3;
            delegate3("Andreas", 25, 1.82f);
        }
        public static void Method1()
        {
            Console.WriteLine("Method 1 was invoked");
        }

        public static float Method2()
        {
            return 4.9f;
        }

        public static void Method3(string name, int age, float height)
        {
            Console.WriteLine("Method 3 name is " + name + " and age is " + age + " and height is " + height);
        }
    }
}
