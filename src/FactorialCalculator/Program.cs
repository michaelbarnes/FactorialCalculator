
using FactorialCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Count() > 0)
            {
                Console.WriteLine("Factorial Calculator");
                Console.WriteLine();

                for (int i = 0; i < args.Count(); i++)
                {
                    try
                    {
                        BigInteger n = ValidateInput(args[i]);

                        n = CalculateFactorial(n);

                        Console.WriteLine("{0}! = {1}", args[i], n);
                    }
                    catch (InvalidInputException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.Message);
                    }
                    catch (FactorialException fex)
                    {
                        Console.WriteLine("Error: {0}", fex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a number!");

                while(true)
                {
                    var input = Console.ReadLine();

                    if (input == "exit") break;

                    try
                    {
                        BigInteger n = ValidateInput(input);

                        n = CalculateFactorial(n);

                        Console.WriteLine("{0}! = {1}", input, n);
                        Console.WriteLine();
                    }
                    catch (InvalidInputException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.Message);
                        Console.WriteLine();
                    }
                    catch (FactorialException fex)
                    {
                        Console.WriteLine("Error: {0}", fex.Message);
                        Console.WriteLine();
                    }
                }
            }
        }

        /// <summary>
        /// Calculate n!
        /// </summary>
        /// <param name="n">Value to calculate</param>
        /// <returns>Factorial of n</returns>
        /// <exception cref="FactorialException">Thrown when the value of n is not valid to calculate factorial.</exception>
        public static BigInteger CalculateFactorial(BigInteger n)
        {
            // -- Initialize the base factorial calculation poBigInteger
            BigInteger factorial = 1;

            // -- Based on rules of Factorial calculation, if n = 0 then 0! = 1
            if (n == 0) return 1;

            // -- Cannot calculate negative value
            if (n < 0) throw new FactorialException(string.Format("{0} is undefined", n));

            return n * CalculateFactorial(n - 1);
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
            BigInteger n = 0;

            // -- Check if the value is actually a long
            var valid = BigInteger.TryParse(input, out n);

            // if the input is invalid, throw exception to calling method.
            if (!valid)
            {
                throw new InvalidInputException(string.Format("Invalid input '{0}'", input));
            }

            return n;
        }
    }
}
