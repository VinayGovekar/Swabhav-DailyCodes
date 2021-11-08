using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class AccountantEmployee:Employee
    {
        private double _perks;
        public AccountantEmployee(string name, int empId) : base(name, empId)
        {
            _basicSalary = 15000;
            _perks = (_basicSalary * 30) / 100;
            SalaryDesign();
        }

        public override void SalaryDesign()
        {
            _annualSalary = _basicSalary + _perks;
            _salarySlip.Add("Perks:" + Convert.ToString(_perks));
        }
    }
}
