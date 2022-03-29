using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorDebugger;
using CalculatorTests;

namespace Calculator.Tests
{
    [TestClass()]
    public class SimpleCalculatorTests
    {
        
        MockDebugger debugger = new MockDebugger();

        [TestMethod()]
        public void SimpleCalculator_WhenIntegersAreAdded_CorrectResultReturned()
        {
            // Arrange

            var simpleCalculator = new SimpleCalculator(debugger);
            var value1 = 1;
            var value2 = 2;
            var expectedResult = 3;

            var result = simpleCalculator.Add(value1,value2);

            Assert.AreEqual(result, expectedResult);
            Assert.AreEqual(debugger.MessageStore[0], $"Add method result: {expectedResult}");
        }

        [TestMethod()]
        public void SimpleCalculator_WhenIntegersAreDivided_CorrectResultReturned()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator(debugger);
            var value1 = 1;
            var value2 = 2;
            var expectedResult = 0.5;

            var result = simpleCalculator.Divide(value1, value2);

            Assert.AreEqual(result, expectedResult);
            Assert.AreEqual(debugger.MessageStore[0], $"Divide method result: {expectedResult}");
        }

        [TestMethod()]
        public void SimpleCalculator_WhenIntegersAreMultiplied_CorrectResultReturned()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator(debugger);
            var value1 = 2;
            var value2 = 3;
            var expectedResult = 6;

            var result = simpleCalculator.Multiply(value1, value2);

            Assert.AreEqual(result, expectedResult);
            Assert.AreEqual(debugger.MessageStore[0], $"Multiply method result: {expectedResult}");
        }

        [TestMethod()]
        public void SimpleCalculator_WhenIntegersAreSubtracted_CorrectResultReturned()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator(debugger);
            var value1 = 1;
            var value2 = 2;
            var expectedResult = -1;

            var result = simpleCalculator.Subtract(value1, value2);

            Assert.AreEqual(result, expectedResult);
            Assert.AreEqual(debugger.MessageStore[0], $"Subtract method result: {expectedResult}");
        }
    }
}