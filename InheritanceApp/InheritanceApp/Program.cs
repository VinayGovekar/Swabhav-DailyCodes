using System;
using InheritanceApp.Model;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
            Console.ReadLine();
        }
        public static void CaseStudy5()
        {
            Console.WriteLine("\nCS5: ");
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello World";
            Console.WriteLine(x.GetType());
            x = 10.5f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
        public static void CaseStudy4()
        {
            Console.WriteLine("\nCS4:");
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }


        public static void AtThePark(Man x)
        {
            Console.WriteLine("At the park");
            x.Play();
        }
        public static void CaseStudy3()
        {
            Console.WriteLine("\nCS3:");
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
        }
        public static void CaseStudy1()
        {
            Console.WriteLine("\nCS1:");
            Man x;
            x = new Man();
            x.Read();
            x.Play();
            x.Walk();
        }
        
        public static void CaseStudy2()
        {
            Console.WriteLine("\nCS2:");
            Boy y;
            y = new Boy();
            y.Jump();
            y.Play();
        }
    }
}
