using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator.Exceptions
{
    /// <summary>
    /// Factorial Exception, used when calculating factorial of n.
    /// </summary>
    public class FactorialException : Exception
    {
        public FactorialException() { }

        public FactorialException(string message)
            : base(message)
        {
        }

        public FactorialException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
