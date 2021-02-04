using System;
using System.Xml.Serialization;
using NUnit.Framework;
using L1_Calculator;

namespace CalculatorNUitTest
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Add_TestAddTwoNumbers()
        {
            var uut = new Calculator();

            double a = 1;
            double b = 2;
            double result = 3;

            Assert.That(result,Is.EqualTo(uut.Add(a,b)));
        }

        [Test]
        public void Add_TestAddTwoNegativeNumbers()
        {
            var uut = new Calculator();

            double a = -1;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_TestAddTwoNumbersOnePosOneNegative()
        {
            var uut = new Calculator();

            double a = 1;
            double b = -2;
            double result = -1;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_TestAddTwoDoubles()
        {
            var uut = new Calculator();

            double a = 1.11;
            double b = 2.12;
            double result = 3.2300000000000004;

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }


        [Test]
        public void Substract_TestSubstractTwoNumbers()
        {
            var uut = new Calculator();

            double a = 5;
            double b = 2;
            double result = 3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoNegativeNumbers()
        {
            var uut = new Calculator();

            double a = -5;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoNumbersOnePosOneNeg()
        {
            var uut = new Calculator();

            double a = 5;
            double b = -2;
            double result = 7;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoDoubles()
        {
            var uut = new Calculator();

            double a = 1.11;
            double b = 2.11;
            double result = -0.99999999999999978;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }


        [Test]
        public void Multiply_TestMultiTwoNumbers()
        {
            var uut = new Calculator();

            double a = 5;
            double b = 2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoNegativeNumbers()
        {
            var uut = new Calculator();

            double a = -5;
            double b = -2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoNumbersOnePosOneNeg()
        {
            var uut = new Calculator();

            double a = -5;
            double b = 2;
            double result = -10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoDoubles()
        {
            var uut = new Calculator();

            double a = 1.15234;
            double b = 2.16454;
            double result = 2.4942860236;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }


        [Test]
        public void Power_OneNumberLiftedInPower()
        {
            var uut = new Calculator();

            double x = 5;
            double exp = 2;
            double result = 25;

            Assert.That(result, Is.EqualTo(uut.Power(x,exp)));
        }


        [TestCase(2,2,1)]
        [TestCase(-2, 2, -1)]
        [TestCase(-2, -2, 1)]
        [TestCase(2, -2, -1)]
        public void Divider_TestingAllFortegn(double a, double b,double expectedresult)
        {
            var uut = new Calculator();

            Assert.That(expectedresult, Is.EqualTo(uut.divide(a, b)));
        }

        [Test]
        public void MultiplyOverload_2times2times2_Equals8()
        {
            var uut = new Calculator();

            double result = 0;
            uut.Multiply(2, 2);
            result = uut.Multiply(2);
            Assert.That(result,Is.EqualTo(8));
        }
        [Test]
        public void PowerOverload_2exp2exp2_Equals16()
        {
            var uut = new Calculator();

            double result = 0;
            uut.Power(2, 2);
            result = uut.Power(2);
            Assert.That(result, Is.EqualTo(16));
        }
        [Test]
        public void divideOverload_2div2div2_Equals05()
        {
            var uut = new Calculator();

            double result = 0;
            uut.divide(2, 2);
            result = uut.divide(2);
            Assert.That(result, Is.EqualTo(0.5));
        }

        [Test]
        public void divide_divideWithZero()
        {
            var uut = new Calculator();

            Assert.That(() => uut.divide(1,0),Throws.TypeOf<ArgumentException>());
        }
        [Test]
        public void divideOverload_divideWithZero()
        {
            var uut = new Calculator();

            Assert.That(() => uut.divide(0), Throws.TypeOf<ArgumentException>());
        }
    }

}