using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorIntTests()
        {
            // Arrange
            Jenkins.Calculator<int> calc = new Jenkins.Calculator<int>();

            // Act
            int add = calc.Add(5, 5);
            int subtract = calc.Subtract(12, 7);
            int multilpy = calc.Multiply(5, 5);
            int divide = calc.Divide(20, 4);

            // Assert
            Assert.AreEqual(add, 10);
            Assert.AreEqual(subtract, 5);
            Assert.AreEqual(multilpy, 25);
            Assert.AreEqual(divide, 5);
        }

        [TestMethod]
        public void CalculatorFloatTests()
        {
            // Arrange
            Jenkins.Calculator<float> calc = new Jenkins.Calculator<float>();

            // Act
            float add = calc.Add(5.0f, 5.0f);
            float subtract = calc.Subtract(12.0f, 7.0f);
            float multilpy = calc.Multiply(5.0f, 5.0f);
            float divide = calc.Divide(20.0f, 4.0f);

            // Assert
            Assert.AreEqual(add, 10);
            Assert.AreEqual(subtract, 5);
            Assert.AreEqual(multilpy, 25);
        }

        [TestMethod]
        public void CalculatorDoubleTests()
        {
            // Arrange
            Jenkins.Calculator<double> calc = new Jenkins.Calculator<double>();

            // Act
            double add = calc.Add(5.0, 5.0);
            double subtract = calc.Subtract(12.0, 7.0);
            double multilpy = calc.Multiply(5.0, 5.0);
            double divide = calc.Divide(20.0, 4.0);
            double power = calc.Power(2.0, 3.0);

            // Assert
            Assert.AreEqual(add, 10);
            Assert.AreEqual(subtract, 5);
            Assert.AreEqual(multilpy, 25);
            Assert.AreEqual(power, 8);
        }
    }
}