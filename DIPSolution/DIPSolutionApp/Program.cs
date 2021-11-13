using System;
using DIPSolutionApp.HighLevelModule;
using DIPSolutionApp.LowLevelModule;

namespace DIPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TaxCalculator(new DBLogger());
            Console.WriteLine(calculator.Calculate(10, 5));
            Console.WriteLine(calculator.Calculate(10, 0));
            Console.ReadKey();
        }
    }
}
