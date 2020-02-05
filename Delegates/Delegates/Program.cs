using System;

namespace Delegates
{
    class Program
    {
        public delegate void Method1Delegate();
        public delegate float Method2Delegate();
        public delegate void Method3Delegate(string name, int age, float height);
        public delegate int MathDelegate(int num1, int num2);
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            // Assign type Method1Delegate to variable delegate1 and point it to Method1.
            Method1Delegate delegate1 = Method1;
            delegate1();

            // Assign type Method2Delegate to variable delegate2 and point it to Method2.
            Method2Delegate delegate2 = Method2;
            Console.WriteLine("Method 2 float value " + delegate2());

            // Assign type Method3Delegate to variable delegate3 and point it to Method3.
            Method3Delegate delegate3 = Method3;
            delegate3("Andreas", 25, 1.82f);

            // Create a new instance of Math class.
            Math mathObject = new Math();
            // Assign type MathDelegate to variable math and point it to Addition method in Math class.
            MathDelegate math = mathObject.Addition;
            Console.WriteLine("Addition 17 + 18 = " + math(17, 18));
            // Assign math variable to Multiplication method in Math class.
            math = mathObject.Multiplication;
            Console.WriteLine("Multiplication 3 * 7 = " + math(3, 7));

            // Assign type MyDelegate to variable myDelegate and point it to Method4.
            MyDelegate myDelegate = Method4;
            // Assign another method to myDelegate
            myDelegate += Method5;
            // Invoke myDelegate, it will call both Method4 and Method5.
            myDelegate();

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

        public static void Method4()
        {
            Console.WriteLine("Method 4 was invoked");
        }

        public static void Method5()
        {
            Console.WriteLine("Method 5 was invoked");
        }
    }
}
