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
        int ZeroInteger;

        [TestMethod]
        public void ShouldCalculateFractorial()
        {
            var result = Factorial.Calculate(PositiveInteger);
            Assert.AreEqual(5040, result);
        }

        [TestMethod]
        public void ShouldThrowFactorialException()
        {
            bool exceptionCaught = false;

            try
            {
                var result = Factorial.Calculate(NegativeInteger);
            }
            catch(FactorialException ex)
            {
                exceptionCaught = true;
            }
            finally
            {
                Assert.IsTrue(exceptionCaught);
            }
        }

        [TestMethod]
        public void ShouldValidateInput()
        {
            var result = Factorial.ValidateInput(ValidInput);
            Assert.Equals(12, result);
        }

        [TestMethod]
        public void ShouldThrowInvalidInputException()
        {
            bool exceptionCaught = false;

            try
            {
                var result = Factorial.ValidateInput(InvalidInput);
            }
            catch (InvalidInputException)
            {
                exceptionCaught = true;
            }
            finally
            {
                Assert.IsTrue(exceptionCaught);
            }
        }

        [TestMethod]
        public void ShouldCalculateFactorial()
        {
            var result = Factorial.Calculate(ZeroInteger);
            Assert.AreEqual(1, result);
        }
    }
}
