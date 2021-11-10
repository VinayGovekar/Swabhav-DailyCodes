using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeApp.Model
{
    class Professor:SalariedEmployee
    {
        private float _totalSalary;
        private float _extraWorkBonus;
        public Professor(int id,string address,string dob):base(id,address,dob)
        {
            _totalSalary = CalculateSalary();
        }
        public override float CalculateSalary()
        {
            _extraWorkBonus = (_basicSalary * 10) / 100;
            return _basicSalary + _extraWorkBonus;
        }
        public float TotalSalary { get { return _totalSalary; } }
    }
}
