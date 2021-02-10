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

        [Test]
        public void Add_TestAddTwoNumbers()
        {
            

            double a = 1;
            double b = 2;
            double result = 3;

            Assert.That(result,Is.EqualTo(uut.Add(a,b)));
        }

        [Test]
        public void Add_TestAddTwoNegativeNumbers()
        {

            double a = -1;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_TestAddTwoNumbersOnePosOneNegative()
        {

            double a = 1;
            double b = -2;
            double result = -1;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

        [Test]
        public void Add_TestAddTwoDoubles()
        {

            double a = 1.11;
            double b = 2.12;
            double result = 3.2300000000000004;

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }


        [Test]
        public void Substract_TestSubstractTwoNumbers()
        {

            double a = 5;
            double b = 2;
            double result = 3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoNegativeNumbers()
        {

            double a = -5;
            double b = -2;
            double result = -3;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoNumbersOnePosOneNeg()
        {

            double a = 5;
            double b = -2;
            double result = 7;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [Test]
        public void Substract_TestSubstractTwoDoubles()
        {

            double a = 1.11;
            double b = 2.11;
            double result = -0.99999999999999978;

            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }


        [Test]
        public void Multiply_TestMultiTwoNumbers()
        {

            double a = 5;
            double b = 2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoNegativeNumbers()
        {

            double a = -5;
            double b = -2;
            double result = 10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoNumbersOnePosOneNeg()
        {

            double a = -5;
            double b = 2;
            double result = -10;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }

        [Test]
        public void Multiply_TestMultiTwoDoubles()
        {

            double a = 1.15234;
            double b = 2.16454;
            double result = 2.4942860236;

            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }


        [Test]
        public void Power_OneNumberLiftedInPower()
        {

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

            Assert.That(expectedresult, Is.EqualTo(uut.divide(a, b)));
        }

        [Test]
        public void MultiplyOverload_2times2times2_Equals8()
        {

            double result = 0;
            uut.Multiply(2, 2);
            result = uut.Multiply(2);
            Assert.That(result,Is.EqualTo(8));
        }
        [Test]
        public void PowerOverload_2exp2exp2_Equals16()
        {

            double result = 0;
            uut.Power(2, 2);
            result = uut.Power(2);
            Assert.That(result, Is.EqualTo(16));
        }
        [Test]
        public void divideOverload_2div2div2_Equals05()
        {

            double result = 0;
            uut.divide(2, 2);
            result = uut.divide(2);
            Assert.That(result, Is.EqualTo(0.5));
        }

        [Test]
        public void divide_divideWithZero()
        {

            Assert.That(() => uut.divide(1,0),Throws.TypeOf<ArgumentException>());
        }
        [Test]
        public void divideOverload_divideWithZero()
        {

            Assert.That(() => uut.divide(0), Throws.TypeOf<ArgumentException>());
        }
        [TestCase(1, 2, 3, 6)]
        [TestCase(1, -2, 3, 2)]
        [TestCase(-1, -2, 3, 0)]
        [TestCase(1, 2, -3, 0)]
        [TestCase(-1, -2, -3, -6)]
        public void AddTest_OverloadAccumulatorTest(double a, double b, double c, double expected)
        {
            uut.Add(a, b);
            Assert.That(expected, Is.EqualTo(uut.Add(c)));
        }

        [TestCase(1, 2, 3, -4)]
        [TestCase(-1, 2, 3, -6)]
        [TestCase(-1, -2, 3, -2)]
        [TestCase(1, 2, -3, 2)]
        [TestCase(-1, -2, -3, 4)]
        public void SubtractTest_OverloadAccumulatorTest(double a, double b, double c, double expected)
        {
            uut.Subtract(a, b);
            Assert.That(expected, Is.EqualTo(uut.Substract(c)));
        }
    }


}