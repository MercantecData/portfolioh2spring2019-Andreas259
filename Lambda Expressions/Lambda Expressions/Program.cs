using System;

namespace LambdaExpressions
{
    class Program
    {
        public delegate int Lambda1Delegate(int num);
        public delegate float Lambda2Delegate(float num1, float num2, float num3);
        public delegate string Lambda3Delegate();
        static void Main(string[] args)
        {
            // Assign variable lambda1 to a Lambda Expression which has the purpose of doubling the input value. 
            Lambda1Delegate lambda1 = num => num * 2;
            int num = 8;
            Console.WriteLine("Lambda expression syntax: num => num * 2");
            Console.WriteLine("num = " + num);
            Console.WriteLine("Result: " + lambda1(7));

            // Assign variable lambda2 to a Lambda Expression which take 3 floats and returns the sum. 
            Lambda2Delegate lambda2 = (num1, num2, num3) => num1 + num2 + num3;
            float num1 = 7.2f;
            float num2 = 6.2f;
            float num3 = 4.2f;
            Console.WriteLine("Lambda expression syntax: (num1, num2, num3) => num1 + num2 + num3");
            Console.WriteLine("num 1 = " + num1 + " and " + "num2 = " + num2 + " and " + "num 3 = " + num3);
            Console.WriteLine("Result: " + lambda2(num1, num2, num3));

            // Assign variable lambda3 to a Lambda Expression which takes no parameters and returns string Hello World.
            Lambda3Delegate lambda3 = () => "Hello world";
            Console.WriteLine("Lambda expression syntax: () => \"Hello World\"");
            Console.WriteLine("Result: " + lambda3());
        }
    }
}
