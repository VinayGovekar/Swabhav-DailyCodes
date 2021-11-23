using System;
using System.Collections;
using IteratorDesignPatternApp.Model;

namespace IteratorDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new EmployeeIterator();
            emps.Add(new Employee(103, "Max"));
            Display(emps);

            Console.ReadKey();
        }
        static void Display(EmployeeIterator iterator)
        {
            foreach(var item in iterator)
            {
                Employee employee = (Employee)item;
                Console.WriteLine(employee.Name);
            }
        }
    }
}
