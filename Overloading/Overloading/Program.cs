using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathObject = new Math();
            
            // Addition
            Console.WriteLine("17 + 21 = " + mathObject.Addition(17, 21));

            // Subtraction
            Console.WriteLine("15 - 13 = " + mathObject.Subtraction(15, 13));

            // Multiplication
            Console.WriteLine("7.2 * 9.4 = " + mathObject.Multiplication(7.2f, 9.4f));

            // Division
            Console.WriteLine("6 / 36 = " + mathObject.Division(6f, 36f));

            // Square Root
            Console.WriteLine("Square root of 5 = " + mathObject.SquareRoot(5d));
        }
    }

    class Math
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Addition(float num1, float num2)
        {
            return num1 + num2;
        }

        public int Addition(string str1, string str2) 
        {
            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);

            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        public int Subtraction(string str1, string str2)
        {
            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);

            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        public int Multiplication(string str1, string str2)
        {
            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);

            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        public int Division(string str1, string str2)
        {
            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);

            return num1 / num2;
        }

        public int SquareRoot(int num)
        {
            if (num > 0)
            {
                int root = num / 3;
                int i;

                for (i = 0; i < 32; i++)
                {
                    root = (root + num / root) / 2;
                }
                return root;
            }
            else
            {
                return 0;
            }
        }
        public double SquareRoot(double num)
        {
            if (num > 0)
            {
                double root = num / 3;
                int i;
                
                for(i = 0; i < 32; i++)
                {
                    root = (root + num / root) / 2;
                }
                return root;
            } 
            else
            {
                return 0;
            }
        }
    }
}
