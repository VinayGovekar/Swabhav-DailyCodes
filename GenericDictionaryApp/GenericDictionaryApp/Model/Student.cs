using System;
namespace GenericDictionaryApp.Model
{
    class Student
    {
        private int _rollNo;
        private int _std;
        private string _name;
        private string _location;

        public Student(int rollno,int std, string name,string location)
        {
            _name = name;
            _std = std;
            _rollNo = rollno;
            _location = location;
        }
        
        public override int GetHashCode()
        {
            string hashCode = Convert.ToString(_rollNo) + Convert.ToString(_std);
            return int.Parse(hashCode);
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._rollNo == studentObj._rollNo && this._std == studentObj._std) return true;
            return false;
        }
    }
}
