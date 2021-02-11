using System;
using System.Xml.Serialization;
using NUnit.Framework;
using L1_Calculator;

namespace CalculatorNUitTest
{
    public class CalculatorTests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        //*************** Add ***************

        [Test]
        public void Add_AddTwoNumbers_SumIsCorrect()
        {
            

            double a = 1;
            double b = 2;
            double result = 3;

            Assert.That(result,Is.EqualTo(uut.Add(a,b)));
        }

        [Test]
        public void Add_AddTwoNegativeNumbers_SumIsCorrect()
        {

            double a = -1;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_AddTwoNumbersOnePosOneNegative_SumIsCorrect()
        {

            double a = 1;
            double b = -2;
            double result = -1;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_AddTwoDoubles_SumIsCorrect()
        {

            double a = 1.11;
            double b = 2.13;
            double result = 3.24;

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        //*************** Substract ***************

        [Test]
        public void Subtract_SubtractTwoInts_SumIsCorrect()
        {

            double a = 5;
            double b = 2;
            double result = 3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_SubtractTwoNegativeNumbers_SumIsCorrect()
        {

            double a = -5;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Subtract_TestSubtractTwoNumbersOnePosOneNeg_SumIsCorrect()
        {

            double a = 5;
            double b = -2;
            double result = 7;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Subtract_TestSubtractTwoDoubles_SumIsCorrect()
        {

            double a = 1.12;
            double b = 2.12;
            double result = -1;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        //*************** Multiply ***************

        [Test]
        public void Multiply_MultiTwoNumbers_ProductIsCorrect()
        {

            double a = 5;
            double b = 2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_MultiTwoNegativeNumbers_ProductIsCorrect()
        {

            double a = -5;
            double b = -2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_MultiTwoNumbersOnePosOneNeg_ProductIsCorrect()
        {

            double a = -5;
            double b = 2;
            double result = -10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_MultiTwoDoubles_ProductIsCorrect()
        {

            double a = 1.15234;
            double b = 2.16454;
            double result = 2.4942860236;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        //*************** Power *************** 

        [Test]
        public void Power_OneNumberLiftedInPower_ResultIsCorrect()
        {

            double x = 5;
            double exp = 2;
            double result = 25;

            Assert.That(result, Is.EqualTo(uut.Power(x,exp)));
        }
        [Test]
        public void Power_OneNumberLiftedInNegativePower_ResultIsCorrect()
        {

            double x = 5;
            double exp = -2;
            double result = 0.04;

            Assert.That(result, Is.EqualTo(uut.Power(x, exp)));
        }

        //*************** Divide *************** 

        [TestCase(2,2,1)]
        [TestCase(-2, 2, -1)]
        [TestCase(-2, -2, 1)]
        [TestCase(2, -2, -1)]
        public void Divide_TwoNumbers_ResultIsCorrect(double a, double b,double expectedresult)
        {

            Assert.That(expectedresult, Is.EqualTo(uut.divide(a, b)));
        }

        [Test]
        public void Divide_DivideWithZero_ExceptionIsThrown()
        {

            Assert.That(() => uut.divide(1, 0), Throws.TypeOf<ArgumentException>());
        }
        //*************** Overload Multiply *************** 

        [Test]
        public void MultiplyOverload_2times2times2_Equals8()
        {

            double result = 0;
            uut.Multiply(2, 2);
            result = uut.Multiply(2);
            Assert.That(result,Is.EqualTo(8));
        }

        //*************** Overload Power *************** 

        [Test]
        public void PowerOverload_2exp2exp2_Equals16()
        {

            double result = 0;
            uut.Power(2, 2);
            result = uut.Power(2);
            Assert.That(result, Is.EqualTo(16));
        }

        //*************** Overload Divide *************** 

        [Test]
        public void DivideOverload_2div2div2_Equals05()
        {

            double result = 0;
            uut.divide(2, 2);
            result = uut.divide(2);
            Assert.That(result, Is.EqualTo(0.5));
        }


        [Test]
        public void DivideOverload_DivideWithZero_ExceptionIsThrown()
        {

            Assert.That(() => uut.divide(0), Throws.TypeOf<ArgumentException>());
        }


        //*************** Overload Accumulator *************** 

        [TestCase(1, 2, 3, 6)]
        [TestCase(1, -2, 3, 2)]
        [TestCase(-1, -2, 3, 0)]
        [TestCase(1, 2, -3, 0)]
        [TestCase(-1, -2, -3, -6)]
        [TestCase(-1, 2, -3, -2)]
        public void Add_OverloadAccumulator_ResultIsCorrect(double a, double b, double c, double expected)
        {
            uut.Add(a, b);
            Assert.That(expected, Is.EqualTo(uut.Add(c)));
        }

        [TestCase(1, 2, 3, -4)]
        [TestCase(-1, 2, 3, -6)]
        [TestCase(-1, -2, 3, -2)]
        [TestCase(1, 2, -3, 2)]
        [TestCase(-1, -2, -3, 4)]
        public void Subtract_OverloadAccumulator_ResultIsCorrect(double a, double b, double c, double expected)
        {
            uut.Subtract(a, b);
            Assert.That(expected, Is.EqualTo(uut.Substract(c)));
        }
    }


}