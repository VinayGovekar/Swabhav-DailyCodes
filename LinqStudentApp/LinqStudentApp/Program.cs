using System;
using System.Collections.Generic;
using System.Linq;
using LinqStudentApp.Model;

namespace LinqStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = CreateStudents();

            DisplayNameAndCGPA(students);
            DisplayStudentsWithLocMumbai(students);
            DisplayNameMoreThan7(students);
            DisplayStudentsInMumbaiAndPune(students);
            DisplayInUnorderedList(students);

            Console.ReadKey();
        }
        
        public static void DisplayNameAndCGPA(List<Student> students)
        {
            Console.WriteLine("\nDisplaying Name and CGPA:");
            students.Select(s => new { s.Name, s.Cgpa }).ToList().ForEach(s => Console.WriteLine("Name: {0}\t CGPA: {1}",s.Name,s.Cgpa));
        }

        public static void DisplayStudentsWithLocMumbai(List<Student> students)
        {
            Console.WriteLine("\nDisplaying Students with location Mumbai:");
            students.Where(s => s.Location == "Mumbai")
                    .ToList()
                    .ForEach(s => Console.WriteLine("Name: {0}\t CGPA: {1}\t Location: {2}\t RollNo: {3}",
                    s.Name,s.Cgpa,s.Location,s.RollNo));
        }

        public static void DisplayStudentsInMumbaiAndPune(List<Student> students)
        {
            Console.WriteLine("\nDisplaying Students with location Mumbai or Pune:");
            students.Where(s => s.Location == "Mumbai" || s.Location=="Pune")
                    .ToList()
                    .ForEach(s => Console.WriteLine("Name: {0}\t CGPA: {1}\t Location: {2}\t RollNo: {3}",
                    s.Name, s.Cgpa, s.Location, s.RollNo));
        }
        public static void DisplayNameMoreThan7(List<Student> students)
        {
            Console.WriteLine("\nDisplaying Students with names more than 7characters:");
            students.Where(s => s.Name.Length > 7)
                    .ToList()
                    .ForEach(s => Console.WriteLine("Name: {0}\t CGPA: {1}\t Location: {2}\t RollNo: {3}",
                    s.Name, s.Cgpa, s.Location, s.RollNo));
        }
        
        public static void DisplayInUnorderedList(List<Student> students)
        {
            Console.WriteLine("\nDisplaying Students in unorderedList:");
            var listString = "<ul>\n";
            students.ForEach(s => listString += "<li>" + s.Name + "</li>\n");
            listString += "</ul>";
            Console.WriteLine(listString);
        }


        public static List<Student> CreateStudents()
        {
            var students = new List<Student>();
            students.Add(new Student { Name = "Skye", Cgpa = 9.29, RollNo = 1, Location = "Mumbai" });

            students.Add(new Student { Name = "Max", Cgpa = 6, RollNo = 2, Location = "China" });

            students.Add(new Student { Name = "Kuma", Cgpa = 7, RollNo = 3, Location = "Japan" });

            students.Add(new Student { Name = "Paine", Cgpa = 8.3, RollNo = 4, Location = "Pune" });

            students.Add(new Student { Name = "YatoKumar", Cgpa = 7.5, RollNo = 5, Location = "Banglore" });

            return students;
        }
    }
}
