using FactorialCalculator.Exceptions;
using System.Numerics;

namespace FactorialCalculator
{
    /// <summary>
    /// Handles all things related to Factorial Calculation and Validation
    /// </summary>
    public static class Factorial
    {
        /// <summary>
        /// Calculate n! recursively
        /// </summary>
        /// <param name="n">Value to calculate</param>
        /// <returns>Factorial of n</returns>
        /// <exception cref="FactorialException">Thrown when the value of n is not valid to calculate factorial.</exception>
        public static BigInteger Calculate(BigInteger n)
        {
            // -- Based on rules of Factorial calculation, if n = 0 then 0! = 1
            if (n == 0) return 1;

            // -- Cannot calculate negative value
            if (n < 0) throw new FactorialException(string.Format("{0} is undefined", n));

            return n * Calculate(n - 1);
        }

        /// <summary>
        /// Validate input of the console application.
        /// </summary>
        /// <param name="input">Standard input</param>
        /// <returns></returns>
        /// <exception cref="InvalidInputException"></exception>
        public static BigInteger ValidateInput(string input)
        {
            // -- Assign 'out' value
            var n = new BigInteger(0);

            // -- Check if the value is actually a bigint
            var valid = BigInteger.TryParse(input, out n);

            // -- There could be a better solution for this, but check the length of the input otherwise a stack overflow exception will occur
            if(input.Length >= 4)
            {
                throw new InvalidInputException("I do not have enough memory to calculate this.");
            }

            // if the input is invalid, throw exception to calling method.
            if (!valid)
            {
                throw new InvalidInputException(string.Format("Invalid input '{0}'", input));
            }

            return n;
        }
    }
}
