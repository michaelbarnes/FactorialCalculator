using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialCalculator.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        Program _program;

        [TestInitialize]
        public void Init()
        {
            _program = new Program();
        }

        [TestMethod]
        public void ValidationTest()
        {
        }
    }
}
