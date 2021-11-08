using System;
using InheritanceConstructorApp2.Model;

namespace InheritanceConstructorApp2
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
            Child c1 = new Child();
            Console.WriteLine(c1.Foo);

            Child c2 = new Child();
            Console.WriteLine(c2.Foo);

            Child c3 = new Child(300);
            Console.WriteLine(c3.Foo);
        }
    }
}
