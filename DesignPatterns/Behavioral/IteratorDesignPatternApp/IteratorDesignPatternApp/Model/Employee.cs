

namespace IteratorDesignPatternApp.Model
{
    public class Employee
    {
        private int _id;
        private string _name;
        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
    }
}
