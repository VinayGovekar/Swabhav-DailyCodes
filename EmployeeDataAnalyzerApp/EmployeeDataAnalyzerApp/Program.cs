using System;
using EmployeeDataAnalyzerApp.Model;
using System.IO;
namespace EmployeeDataAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            var fileReader = new EmployeeFileReader();
            fileReader.ReadFromFile(employeeManager, Directory.GetCurrentDirectory() + "/employeeData.txt");
            Console.WriteLine("[All data after removing redundant information]");
            Console.WriteLine("Total No of Employees: {0}",employeeManager.Employees.Count);
            Console.WriteLine("\nMaximum Salaried employee:");
            var employeePrinter = new EmployeeConsolePrinter();
            employeePrinter.PrintEmployee(employeeManager.FindHighestSalariedEmployee());
            string designation = "'CLERK'";
            int deptNum = 10;
            Console.WriteLine("\nNo of employees who are {0} and have department number as {1} : {2}",
                              designation,deptNum,employeeManager.FindNoOfEmployeesBasedOnBoth(deptNum,designation));
            Console.ReadKey();
        }
    }
}
