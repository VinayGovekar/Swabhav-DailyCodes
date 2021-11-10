using System;
using System.Linq;
using EngineeringCollegeApp.Model;

namespace EngineeringCollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadLine();
        }

        public static void CaseStudy1()
        {
            PrintDetails(new Student("Mech", 102, "Mumbai", "24-09-1999"));
            PrintDetails(new Professor(101, "Chennai", "17-12-2008"));
        }

        public static void PrintDetails(Person person)
        {
            Console.WriteLine("\n{0}:-", person.GetType().ToString().Split('.').Last());
            Console.WriteLine("ID: {0}",person.ID);
            Console.WriteLine("Address: {0}", person.Address);
            Console.WriteLine("DOB: {0}",person.DOB);
            if(person is Professor)
            {
                var professorPerson = (Professor)person;
                Console.WriteLine("Salary: Rs {0}", professorPerson.TotalSalary);
            }
            if(person is Student)
            {
                var studentPerson = (Student)person;
                Console.WriteLine("Branch: {0}",studentPerson.Branch);
            }
        }
    }
}
