using System;
using DIPViolationApp.HighLevelModule;
namespace DIPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TaxCalculator(LogPolicyType.DB);
            Console.WriteLine(calculator.Calculate(10,5));
            Console.WriteLine(calculator.Calculate(10,0));
            Console.ReadKey();
        }
    }
}
