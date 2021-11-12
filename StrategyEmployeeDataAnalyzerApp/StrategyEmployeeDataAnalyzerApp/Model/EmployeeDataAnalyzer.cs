using System;
using System.Collections.Generic;


namespace StrategyEmployeeDataAnalyzerApp.Model
{
    public class EmployeeDataAnalyzer
    {
        private List<Employee> _employees;
        public EmployeeDataAnalyzer(ILoadData source)
        {
            _employees = source.LoadData();
        }
        public List<Employee> Employees { get { return _employees; } }

        public Employee MaxSalaryEmployee()
        {
            Employee maxSal = Employees[0];
            foreach (var employee in Employees)
            {
                if (employee.Salary > maxSal.Salary) maxSal = employee;
            }
            return maxSal;
        }
        public Dictionary<int,int> FindDeptNumberWiseEmployeeCount() {
            var FreqMap = new Dictionary<int, int>();
            foreach(var employee in Employees)
            {
                if (!FreqMap.ContainsKey(employee.DepartmentNumber))
                {
                    FreqMap.Add(employee.DepartmentNumber, EmployeeCountForDeptNum(employee.DepartmentNumber));
                }
            }
            return FreqMap;
        }
        public Dictionary<string,int> FindJobWiseEmployeeCount() {
            var FreqMap = new Dictionary<string, int>();
            foreach (var employee in Employees)
            {
                if (!FreqMap.ContainsKey(employee.Designation))
                {
                    FreqMap.Add(employee.Designation,EmployeeCountForJob(employee.Designation));
                }
            }
            return FreqMap;
        }

        private int EmployeeCountForJob(string job)
        {
            List<Employee> employeesDesignation = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.Designation.ToLower() == job.ToLower()) employeesDesignation.Add(employee);
            }
            return employeesDesignation.Count;
        }

        private int EmployeeCountForDeptNum(int deptNum)
        {
            List<Employee> employeesDeptNum = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.DepartmentNumber == deptNum) employeesDeptNum.Add(employee);
            }
            return employeesDeptNum.Count;
        }
    }
}
