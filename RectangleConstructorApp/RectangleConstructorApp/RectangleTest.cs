using System;


namespace RectangleConstructorApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
            
        }
        static void CaseStudy2()
        {
            Rectangle r2= new Rectangle(101, 20, "Red","Yellow");
            Console.WriteLine("\nOverloaded Constructor:");
            PrintDetails(r2);
            Console.WriteLine("BorderColor: {0}",r2.GetBorderColor());
        }
        static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(101, 20, "Red");
            PrintDetails(r1);
        }
        static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Details:-\nWidth: {0}, Height: {1}, Color: {2}, Area: {3}",r.GetWidth(),r.GetHeight(),r.GetColor(),r.CalculateArea());
        }
    }
}
