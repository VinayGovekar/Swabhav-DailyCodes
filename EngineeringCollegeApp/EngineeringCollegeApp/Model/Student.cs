
namespace EngineeringCollegeApp.Model
{
    class Student:Person
    {
        private string _branch;
        public Student(string branch,int id,string address, string dob) : base(id, address, dob)
        {
            _branch = branch;
        }
        public string Branch { get { return _branch; } }
    }
}
