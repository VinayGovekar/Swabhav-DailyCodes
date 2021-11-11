using System;
using System.Collections.Generic;

namespace EmployeeDataAnalyzerApp.Model
{
    public class EmployeeManager
    {
        private List<Employee> _employees = new List<Employee>();
        
        public void AddEmployee(Employee employee)
        {
            if (!CheckIfEmployeeAlreadyPresent(employee)) Employees.Add(employee);
        }
        private bool CheckIfEmployeeAlreadyPresent(Employee employee)
        {
            if (Employees.Contains(employee)) return true;
            return false;
        }

        public Employee FindHighestSalariedEmployee()
        {
            Employee maxSal=Employees[0];
            foreach(var employee in Employees)
            {
                if (employee.Salary > maxSal.Salary) maxSal = employee;
            }
            return maxSal;
        }
        public int FindNoOfEmployeeBasedOnDesignation(string designation)
        {
            List<Employee> employeesDesignation = new List<Employee>();
            foreach(var employee in Employees)
            {
                if (employee.Designation.ToLower() == designation.ToLower()) employeesDesignation.Add(employee);
            }
            return employeesDesignation.Count;
        }
        public int FindNoOfEmployeeBasedOnDepartmentNumber(int deptNumber)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.DepartmentNumber==deptNumber) employees.Add(employee);
            }
            return employees.Count;
        }
        public int FindNoOfEmployeesBasedOnBoth(int deptNumber,string designation)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.DepartmentNumber == deptNumber&& 
                    employee.Designation.ToLower() == designation.ToLower()) employees.Add(employee);
            }
            return employees.Count;
        }
        public List<Employee> Employees { get { return _employees; } }
    }
}
