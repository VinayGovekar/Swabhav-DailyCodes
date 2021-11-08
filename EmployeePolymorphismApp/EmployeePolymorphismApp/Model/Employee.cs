using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    abstract class Employee
    {
        private string _name;
        private int _empId;
        protected double _basicSalary;
        protected double _annualSalary;
        protected List<string> _salarySlip = new List<string>();

        public Employee(string name,int empId)
        {
            _name = name;
            _empId = empId;
        }
        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int EmployeeId
        {
            get
            {
                return _empId;
            }
        }
        public double AnnualSalary
        {
            get
            {
                return _annualSalary;
            }
        }
        public List<string> SalarySlip
        {
            get
            {
                return _salarySlip;
            }
        }
        public abstract void SalaryDesign();
    }
}
