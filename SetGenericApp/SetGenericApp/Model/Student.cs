
namespace SetGenericApp.Model
{
    class Student
    {
        private int _rollNo;
        private string _name;
        private string _location;

        public Student(int rollno, string name,string location)
        {
            _name = name;
            _rollNo = rollno;
            _location = location;
        }
        public override int GetHashCode()
        {
            return _rollNo;
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._rollNo == studentObj._rollNo) return true;
            return false;
        }
    }
}
