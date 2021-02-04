using System;

namespace L1_Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public double Accumulator{get; private set; }

    public Calculator()
    {
        Accumulator = 0;
    }

        public double Add(double a, double b)
        {
            Accumulator = a + b; 
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }

        public double divide(double a, double b)
        {
            double result = (a / b);
            return result;
        }

        public void clear()
        {
            Accumulator = 0;
        }

        public double Add(double added)
        {
            return Accumulator += added;
        }

        public double Substract(double substractor)
        {
            return Accumulator -= substractor;
        }


    }
}
