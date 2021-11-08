using System;
using System.Collections.Generic;
using SetGenericApp.Model;
namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }

        public static void CaseStudy2()
        {
            Student s1 = new Student(101, "Vinay", "Mumbai");
            Student s2 = new Student(101, "Vinay", "Mumbai");
            Student s3 = new Student(102, "Vinay", "Mumbai");
            HashSet<Student> students = new HashSet<Student>();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            Console.WriteLine(students.Count);
        }
        public static void CaseStudy1()
        {
            HashSet<int> numberSet = new HashSet<int>();
            numberSet.Add(10);
            numberSet.Add(200);
            numberSet.Add(5);
            numberSet.Add(5);
            numberSet.Add(300);
            Console.WriteLine("Count: {0}",numberSet.Count);
            foreach(int number in numberSet) Console.WriteLine(number);
        }
    }
}
