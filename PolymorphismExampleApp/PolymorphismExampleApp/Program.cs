using System;
using PolymorphismExampleApp.Model;

namespace PolymorphismExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Circle c1 = new Circle();
            Square s1 = new Square();
            Console.WriteLine("Area of Rectangle: {0}",r1.Area());
            Console.WriteLine("Area of Circle: {0}",c1.Area());
            Console.WriteLine("Area of Square: {0}",s1.Area());
            Console.Read();

        }
    }
}
