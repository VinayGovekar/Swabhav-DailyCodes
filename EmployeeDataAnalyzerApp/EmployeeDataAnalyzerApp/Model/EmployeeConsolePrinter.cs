using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
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
        public void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees) PrintEmployee(employee);
        }
    }
}
