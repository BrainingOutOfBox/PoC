using NUnit.Framework;
using System;
using Forms.HelloWorld;

namespace HelloGlobe.Test
{
    [TestFixture()]
    public class Test
    {
        [Test]
        public void TestExampleCalculatorAddition()
        {
            ICalculator calc = new ExampleCalculator();

            Assert.AreEqual(3, calc.Add(1, 2));
        }

        [Test]
        public void TestExampleCalculatorSubtraction()
        {
            ICalculator calc = new ExampleCalculator();

            Assert.AreEqual(10, calc.Subtract(20, 10));
        }
        [Test]
        public void TestFailure()
        {
            Assert.Fail();
        }
    }
}
