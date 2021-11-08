using System;
using AccountEqualityApp.Model;

namespace AccountEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        private static void CaseStudy1()
        {
            Account acc1 = new Account("Vinay", 101, 1000.20);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());
        }
        private static void CaseStudy2()
        {
            Account acc1 = new Account("Vinay", 101, 1000.20);
            Account acc2 = new Account("Vinay", 101, 1000.20);
            Console.WriteLine(acc1==acc2);
            Console.WriteLine(acc1.Equals(acc2));
        }
    }
}
