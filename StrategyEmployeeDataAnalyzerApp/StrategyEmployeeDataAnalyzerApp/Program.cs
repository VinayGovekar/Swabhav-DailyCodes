using System;
using System.IO;
using StrategyEmployeeDataAnalyzerApp.Model;
using StrategyEmployeeDataAnalyzerApp.Model.Loader;
namespace StrategyEmployeeDataAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[All data after removing redundant values]");
            Console.WriteLine("\nFROM FILE:");
            PrintAnalyzer(new EmployeeDataAnalyzer(new ReadFromFile()));
            Console.WriteLine("\nFROM URL:");
            PrintAnalyzer(new EmployeeDataAnalyzer(new ReadFromURL()));
            Console.ReadLine();
        }
        public static void PrintAnalyzer(EmployeeDataAnalyzer analyzer)
        {
            var printer = new EmployeeConsolePrinter();
            printer.PrintEmployee(analyzer.MaxSalaryEmployee());
            printer.PrintJobFrequencyMap(analyzer.FindJobWiseEmployeeCount());
            printer.PrintDeptNumFrequncyMap(analyzer.FindDeptNumberWiseEmployeeCount());
        }
    }
}
