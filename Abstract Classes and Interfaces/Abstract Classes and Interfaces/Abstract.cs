using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    // Abstract class, can't be initiated but only inherit.
    public abstract class Abstract
    {
        // Set abstract method.
        public abstract void Start();
    }

    public class SubClass1 : Abstract
    {
        // Override abstract method.
        public override void Start()
        {
            Console.WriteLine("Subclass 1");
        }
    }

    public class SubClass2 : Abstract
    {
        // Override abstract method.
        public override void Start()
        {
            Console.WriteLine("Subclass 2");
        }
    }

    public class SubClass3 : Abstract
    {
        // Override abstract method.
        public override void Start()
        {
            Console.WriteLine("Subclass 3");
        }
    }
}
