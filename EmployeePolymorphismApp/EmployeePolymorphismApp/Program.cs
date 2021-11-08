using System;
using System.Reflection;
using System.Linq;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***EmployeePolymorphism***");
            DeveloperEmployee emp1 = new DeveloperEmployee("Vinay", 101);
            PrintDetails(emp1);
            ManagerEmployee emp2 = new ManagerEmployee("Neeraj", 102);
            PrintDetails(emp2);
            AccountantEmployee emp3 = new AccountantEmployee("Nelson", 103);
            PrintDetails(emp3);
            Console.ReadLine();
        }
        /*
        public static void PrintDetails(Employee employee)
        {
            PropertyInfo[] prop = employee.GetType().GetProperties();
            Console.WriteLine("\n\nEmployee Details:");
            Console.WriteLine("Emp ID: {0}", employee.EmployeeId);
            Console.WriteLine("Name: {0}",employee.Name);
            Console.WriteLine("Employee type: {0}", employee.GetType().ToString().Split('.').Last());
            Console.WriteLine("\nSalary Details:");
            for (int i = 0; i < prop.Length - 2; i++)
            {
                Console.WriteLine("{0}: {1}", prop[i].Name, prop[i].GetValue(employee));
            }
        }*/

        public static void PrintDetails(Employee employee)
        {
            PropertyInfo[] prop = employee.GetType().GetProperties();
            Console.WriteLine("\n\nEmployee Details:");
            Console.WriteLine("Emp ID: {0}", employee.EmployeeId);
            Console.WriteLine("Name: {0}", employee.Name);
            Console.WriteLine("Employee type: {0}", employee.GetType().ToString().Split('.').Last());
            Console.WriteLine("\nSalary Details:");
            Console.WriteLine("Basic Salary: {0}",employee.BasicSalary);
            foreach (string salary in employee.SalarySlip) Console.WriteLine(salary);
            Console.WriteLine("Annual Salary: {0}",employee.AnnualSalary);
        }
    }
}
