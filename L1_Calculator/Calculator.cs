using System;

namespace L1_Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Calculator()
        {
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }


        public void clear()
        {
        }

    }
}
