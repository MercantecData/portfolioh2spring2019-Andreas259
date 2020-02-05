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
        public delegate int IntDelegate(int num1, int num2);
        public delegate float FloatDelegate(float num1, float num2);
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

            // Assign type IntDelegate to variable addition and point it to Lambda Expression
            IntDelegate addition = (num1, num2) => num1 + num2;
            Console.WriteLine("Addition 13 + 4 = " + addition(13, 4));
            // Assign type IntDelegate to variable subtraction and point it to Lambda Expression
            IntDelegate subtraction = (num1, num2) => num1 - num2;
            Console.WriteLine("Subtraction 8 - 2 = " + subtraction(8, 2));
            // Assign type IntDelegate to variable subtraction and point it to Lambda Expression
            FloatDelegate multiplication = (num1, num2) => num1 * num2;
            Console.WriteLine("Multiplication 4.2 * 3.1 = " + multiplication(4.2f, 3.1f));
            // Assign type IntDelegate to variable division and point it to Lambda Expression
            FloatDelegate division = (num1, num2) => num1 / num2;
            Console.WriteLine("Multiplication 4 / 32 = " + division(4, 32));
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
