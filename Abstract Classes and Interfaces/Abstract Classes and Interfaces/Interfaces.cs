using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    interface IMyInterface
    {
        void Method1();
        void Method2();
        void Method3();
    }

    public class InterfaceClass1 : IMyInterface
    {
        public InterfaceClass1()
        {
            Method1();
            Method2();
            Method3();
        }
        public void Method1()
        {
            Console.WriteLine("Method 1 was invoked");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 was invoked");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3 was invoked");
        }
    }

    public class InterfaceClass2 : IMyInterface
    {
        public InterfaceClass2()
        {
            Method1();
            Method2();
            Method3();
        }
        public void Method1()
        {
            Console.WriteLine("Method 1 was invoked");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 was invoked");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3 was invoked");
        }
    }
}
