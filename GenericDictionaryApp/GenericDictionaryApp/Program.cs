using System;
using System.Collections.Generic;
using GenericDictionaryApp.Model;

namespace GenericDictionaryApp
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
            var students = new Dictionary<Student, Student>();
            var s1 = new Student(12, 10, "Vinay", "Mumbai");
            var s2 = new Student(10, 12, "Chinmay", "Mumbai");
            var s3 = new Student(12, 10, "VINAY", "Mumbai");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            
            students.Add(s1,s1);
            students.Add(s2, s2);
            bool result = !students.ContainsKey(s3);
            if (result) students.Add(s3, s3);
            
            Console.WriteLine("\nCount: {0}",students.Count);
        }
        public static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "One");
           // map.Add(1, "ONE");
            map.Add(2, "TWO");
            Console.WriteLine(map.Count);

            foreach (var item in map)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
