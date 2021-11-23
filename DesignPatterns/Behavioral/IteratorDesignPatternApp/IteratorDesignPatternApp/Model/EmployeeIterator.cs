using System;
using System.Collections;
using System.Collections.Generic;


namespace IteratorDesignPatternApp.Model
{
    public class EmployeeIterator:IIterator
    {
        private List<Employee> _employees= new List<Employee>();
        private int _current;

        public EmployeeIterator()
        {
            _current = 0;
            Add(new Employee(101,"Vinay"));
            Add(new Employee(102,"Shivam"));
        }
        public void Add(Employee emp)
        {
            _employees.Add(emp);
            _current += 1;
        }
        public int Count()
        {
            return _employees.Count;
        }

        public object Current()
        {
            return _employees[_current];
        }

        public IEnumerator GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (_employees[_current + 1] == null) return false;
            return true;
        }
    }
}
