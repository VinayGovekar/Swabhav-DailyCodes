using System;
using CalculatorEventLib;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calci = new Calculator();
            calci.OperationCompleted += PrintDetails;
            calci.Add(10, 2);
            calci.Substrct(5, 2);

            Console.ReadKey();
        }
        static void PrintDetails(string type,int first, int second, double result)
        {
            Console.WriteLine("\nOperation:");
            Console.WriteLine("First: {0}\nSecond: {1}\nType: {2}\nResult: {3}",first,second,type,result);
        }
    }
}
