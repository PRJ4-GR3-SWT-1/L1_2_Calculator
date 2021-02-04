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

        [TestCase(1, 2, 3, 6)]
        [TestCase(1,-2,3,2)]
        [TestCase(-1,-2,3,0)]
        [TestCase(1,2,-3,0)]
        [TestCase(-1,-2,-3,-6)]
        public void AddTest_OverloadAccumulatorTest(double a, double b, double c, double expected)
        {
            var uut = new Calculator();
            uut.Add(a, b);
            Assert.That(expected, Is.EqualTo(uut.Add(c)));
        }

        [TestCase(1,2,3,-4)]
        [TestCase(-1,2,3,-6)]
        [TestCase(-1,-2,3,-2)]
        [TestCase(1,2,-3,2)]
        [TestCase(-1,-2,-3,4)]
        public void SubstractTest_OverloadAccumulatorTest(double a, double b, double c, double expected)
        {
            var uut = new Calculator();
            uut.Subtract(a, b);
            Assert.That(expected,Is.EqualTo(uut.Substract(c)));
        }



    }

}