using System;

namespace L1_Calculator
{
    public class Calculator
    {


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
        public double Multiply(double numberEnd)
        {
            Accumulator = Accumulator * numberEnd;
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }
        public double Power(double exp)
        {
            double result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
        }

        public double divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("You can't divide by 0");
            double result = (a / b);
            Accumulator = result;
            return result;
        }
        public double divide(double aEnd)
        {
            if (aEnd == 0) throw new ArgumentException("You can't divide by 0");
            double result = (Accumulator / aEnd);
            Accumulator = result;
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
