using System.Collections.Generic;

namespace EngineeringCollegeApp.Model
{
    abstract class SalariedEmployee:Person
    {
        protected float _basicSalary;
       
        public SalariedEmployee(int id,string address,string dob) : base(id, address, dob) {
            _basicSalary = 20000;
        }
        public abstract float CalculateSalary();
    }
}
