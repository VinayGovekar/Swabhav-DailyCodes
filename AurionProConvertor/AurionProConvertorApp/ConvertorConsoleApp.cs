using System;
using AurionProConvertor;
namespace AurionProConvertorApp
{
    class ConvertorConsoleApp
    {
        static void Main(string[] args)
        {
            CaseStudy2();
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            Console.WriteLine(TemperatureConvertor.CelciusToFahrenheit(28));
        }
        public static void CaseStudy2()
        {
            Console.WriteLine(CurrencyConvertor.Convert(1,"INR","EUR"));
        }
    }
}
