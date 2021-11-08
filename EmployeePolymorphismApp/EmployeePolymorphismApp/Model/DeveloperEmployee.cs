using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class DeveloperEmployee:Employee
    {
        private double _pa;
        private double _ot;

        public DeveloperEmployee(string name, int empId) : base(name, empId)
        {
            _basicSalary = 20000;
            _pa = (_basicSalary * 40) / 100;
            _ot = (_basicSalary * 30) / 100;
            SalaryDesign();
        }

        public override void SalaryDesign()
        {
            _annualSalary = _basicSalary + _pa + _ot;
            _salarySlip.Add("PA:" + Convert.ToString(_pa));
            _salarySlip.Add("OT:" + Convert.ToString(_ot));
        }
    }
}
