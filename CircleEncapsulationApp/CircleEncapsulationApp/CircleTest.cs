using System;
using CircleEncapsulationApp.Model;
namespace CircleEncapsulationApp
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
            Console.ReadLine();
        }

        static void SetDetails(float radius, string borderColor,string fillColor, Circle c)
        {
            c.SetRadius(radius);
            c.SetFillColor(fillColor);
            c.SetBorderColor(borderColor);
        }
       
        static void CaseStudy3()
        {
            Circle[] manyCircles = new Circle[3];
            float radius = 1.0f;
            for (int i = 0;i<manyCircles.Length;i++) {
                manyCircles[i] = new Circle();
                SetDetails(radius, "Red", "Green", manyCircles[i]);
                radius = radius+ 2.00f;
            }
            PrintDetails(manyCircles);
            PrintBiggestCircle(manyCircles);
        }

        static void PrintBiggestCircle(Circle[] c)
        {
            float biggestRadius = c[0].GetRadius();
            Circle bigCircle=new Circle();
            for (int i = 0;i<c.Length;i++)
            {
                if (c[i].GetRadius() > biggestRadius)
                {
                    biggestRadius = c[i].GetRadius();
                    bigCircle = c[i];

                }
            }
            Console.WriteLine("\nBiggest Circle is:");
            PrintDetails(bigCircle);
        }

        static void PrintDetails(Circle circle)
        {
            Console.WriteLine("\nDetails:-\nRadius: {0}, BorderColor: {1}, FillColor: {2}, Area: {3}", circle.GetRadius(), circle.GetBorderColor(), circle.GetFillColor(), circle.CalculateArea());
        }
        static void PrintDetails(Circle[] circles)
        {
            Console.WriteLine("Displaying Circle Array:\n");
            foreach (Circle circle in circles)
            {
                PrintDetails(circle);
            }
        }
        static void CaseStudy2()
        {
            Console.WriteLine("\nArea of anonymous circle obj: {0}",new Circle().CalculateArea());
            PrintDetails(new Circle());
        }
        static void CaseStudy1() {
            Circle firstCircle = new Circle();
            Console.WriteLine("Before Setting:\nRadius: {0}, BorderColor: {1}, FillColor: {2}", firstCircle.GetRadius(), firstCircle.GetBorderColor(), firstCircle.GetFillColor());

            //Setting Data
            firstCircle.SetRadius(100.0f);
            firstCircle.SetBorderColor("Yellow");
            firstCircle.SetFillColor("gReEn");

            Console.WriteLine("\nAfter Setting:\nRadius: {0}, BorderColor: {1}, FillColor: {2}", firstCircle.GetRadius(), firstCircle.GetBorderColor(), firstCircle.GetFillColor());
            Console.WriteLine("\nArea of Circle: {0}", firstCircle.CalculateArea());
            Console.ReadLine();
        }
    }
}
