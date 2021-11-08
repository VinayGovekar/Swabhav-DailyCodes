using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class ManagerEmployee:Employee
    {
        private double _hra;
        private double _ta;
        private double _da;
        public ManagerEmployee(string name,int empId):base(name,empId)
        {
            _basicSalary = 25000;
            _hra = (_basicSalary*50) / 100;
            _ta = (_basicSalary * 40) / 100;
            _da = (_basicSalary * 30) / 100;
            SalaryDesign();
        }
        public override void SalaryDesign()
        {
            _annualSalary = _basicSalary + _hra + _ta + _da;
            _salarySlip.Add("HRA:" + Convert.ToString(_hra));
            _salarySlip.Add("TA:" + Convert.ToString(_ta));
            _salarySlip.Add("DA:" + Convert.ToString(_da));
        }
    }
}
