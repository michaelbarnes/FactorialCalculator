using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialCalculator.Exceptions;

namespace FactorialCalculator.UnitTests
{
    [TestClass]
    public class FactorialTest
    {
        // -- Test Variables
        string ValidInput = "12";
        string InvalidInput = "";
        int PositiveInteger = 7;
        int NegativeInteger = -1;
        int ZeroInteger = 0;

        [TestMethod]
        public void ShouldCalculateFractorial()
        {
            var result = Factorial.Calculate(PositiveInteger);
            Assert.AreEqual(5040, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FactorialException))]
        public void ShouldThrowFactorialException()
        {
            var result = Factorial.Calculate(NegativeInteger);
        }

        [TestMethod]
        public void ShouldValidateInput()
        {
            var result = Factorial.ValidateInput(ValidInput);
            Assert.Equals(12, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void ShouldThrowInvalidInputException()
        {
            var result = Factorial.ValidateInput(InvalidInput);
        }

        [TestMethod]
        public void ShouldCalculateFactorial()
        {
            var result = Factorial.Calculate(ZeroInteger);
            Assert.AreEqual(1, result);
        }
    }
}
