using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEmployeeDataAnalyzerApp.Model
{
    public class EmployeeConsolePrinter
    {
        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name: {0}", employee.Name);
            Console.WriteLine("Id: {0}", employee.ID);
            Console.WriteLine("Designation: {0}", employee.Designation);
            Console.WriteLine("Manager ID: {0}", employee.ManagerID);
            Console.WriteLine("Date of Joining: {0}", employee.DateOfJoining);
            Console.WriteLine("Salary: {0}", employee.Salary);
            Console.WriteLine("Commission: {0}", employee.Commission);
            Console.WriteLine("Departmenet ID: {0}", employee.DepartmentNumber);
        }
        public void PrintJobFrequencyMap(Dictionary<string,int> frenMap)
        {
            Console.WriteLine("\nDesignation Wise Count:");
            foreach (var row in frenMap) Console.WriteLine("{0} \t: {1}",row.Key,row.Value);
        }
        public void PrintDeptNumFrequncyMap(Dictionary<int,int> frenMap)
        {
            Console.WriteLine("\nDepartment Number Wise Count:");
            foreach (var row in frenMap) Console.WriteLine("{0} : {1}", row.Key, row.Value);
        }
    }
}

