
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
    public class Program
    {
        static void Main(string[] args)
        {
            // -- Check if any params are passed
            if (args.Count() > 0)
            {
                Console.WriteLine("Factorial Calculator");
                Console.WriteLine();

                for (int i = 0; i < args.Count(); i++)
                {
                    try
                    {
                        // -- Validate 
                        BigInteger n = Factorial.ValidateInput(args[i]);

                        // -- Calculate 
                        n = Factorial.Calculate(n);
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

                Console.WriteLine("Execution completed.");
                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Factorial Calculator (n!)");
                Console.WriteLine("Please enter a number:");
                Console.WriteLine();

                // -- This while loop allows the user to enter as many numbers to calculate the factorial of the given number
                // -- The 'exit' command can be used to exit the process
                while(true)
                {
                    // -- Read input
                    var input = Console.ReadLine();

                    // -- Exit if the input == 'exit'
                    if (input == "exit") break;

                    try
                    {
                        // -- Validate
                        BigInteger n = Factorial.ValidateInput(input);

                        // -- Calculate
                        n = Factorial.Calculate(n);

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
    }
}
