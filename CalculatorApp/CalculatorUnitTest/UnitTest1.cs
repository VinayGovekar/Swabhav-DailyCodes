using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorApp;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingTwoNumbersTest()
        {
            Calculator c1 = new Calculator();
            int result = c1.Add(10, 15);
            Assert.AreEqual<int>(25, result);
            //Assert.AreEqual<int>(30, result);
        }
    }
}
