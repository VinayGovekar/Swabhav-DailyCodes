using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AurionProConvertor;

namespace AurionProConverterUnitTest
{
    [TestClass]
    public class CurrencryTest
    {
        [TestMethod]
        public void INR100ToUSD()
        {
            double result = CurrencyConvertor.Convert(100,"INR","USD");
            Assert.AreEqual<double>(1.3348, result);
        }

        [TestMethod]
        public void NegetiveAmount()
        {
            double result = CurrencyConvertor.Convert(-100, "INR", "USD");
            Assert.AreEqual<double>(0, result);
        }
    }
}
