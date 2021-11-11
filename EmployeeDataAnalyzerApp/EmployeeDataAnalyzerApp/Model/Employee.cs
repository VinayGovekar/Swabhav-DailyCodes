using System;
namespace EmployeeDataAnalyzerApp.Model
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _designation;
        private int _managerId;
        private string _dateOfJoining;
        private double _salary;
        private double _commision;
        private int _deptNumber;
        public Employee(int id,string name,string designation,int manager,string date,double salary,double commision, int dept)
        {
            _id = id;
            _name = name;
            _designation = designation;
            _managerId = manager;
            _dateOfJoining = date;
            _salary = salary;
            _commision = commision;
            _deptNumber = dept;
        }
        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public string Designation { get { return _designation; } }
        public int ManagerID { get { return _managerId; } }
        public string DateOfJoining { get { return _dateOfJoining; } }
        public double Salary { get { return _salary; } }
        public double Commission { get { return _commision; } }
        public int DepartmentNumber { get { return _deptNumber; } }
        public override int GetHashCode()
        {
            return _id;
        }
        public override bool Equals(object obj)
        {
            Employee emp = (Employee)obj;
            if (this.ID == emp.ID) return true;
            return false;
        }
    }
}
