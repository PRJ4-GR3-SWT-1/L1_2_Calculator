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

            double a = 1.15234;
            double b = 2.16454;
            double result = 3.31688;

            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
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

            double a = 1.15234;
            double b = 2.16454;
            double result = -1.0122;

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



    }

}