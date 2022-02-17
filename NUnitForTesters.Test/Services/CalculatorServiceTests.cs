using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        CalculatorService calc;
        [SetUp]
        public void Setup()
        {
            calc = new CalculatorService();
        }

        [TestCase(11, 12, -1)]
        [TestCase(0, 12, -12)]
        [TestCase(-13, -12, -1)]
        public void TestAddFunction(int result, int a, int b)
        {
            Assert.AreEqual(result, calc.Add(a, b));
        }

        [TestCase(7, 49, 42)]
        public void TestSubFunction(int result, int a, int b)
        {
            Assert.AreEqual(result, calc.Sub(a, b));
        }

        [TestCase(4, 2, 2)]
        public void TestMulFunction(int result, int a, int b)
        {
            Assert.AreEqual(result, calc.Mul(a,b));
        }

        [TestCase(4, 16, 4)]
        [TestCase(2, 4, 2)]
        public void TestDivFunction(int result, int a, int b)
        {
            Assert.AreEqual(result, calc.Div(a,b));
        }
    }
}