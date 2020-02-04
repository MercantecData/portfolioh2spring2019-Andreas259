using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
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

                for (int i = 0; i < 32; i++)
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

        public int Exponentiation(int num, int exponent)
        {

            for (int i = exponent; i > 1; i--)
            {
                num *= num;
            }

            return num;
        }
    }
}
