using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AurionProConvertor;

namespace AurionProConverterUnitTest
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void Celcius28ToFahrenheit()
        {
            double result = TemperatureConvertor.CelciusToFahrenheit(28);
            Assert.AreEqual<double>(82.4, result);
        }

        [TestMethod]
        public void Fahrenheit100ToKelvin()
        {
            double result = TemperatureConvertor.FahrenheitToKelvin(100);
            Assert.AreEqual<double>(310.928, result);
        }

    }
}
