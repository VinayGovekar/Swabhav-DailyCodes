using System;
using RectangleEnumApp.Model;

namespace RectangleEnumApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }
        private static void CaseStudy1()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Rectangle firstRectangle = new Rectangle();
            firstRectangle.Height = 200;
            firstRectangle.Width = 50;
            firstRectangle.BorderColor = ColorType.GREEN;
            PrintDetails(firstRectangle);
            Console.ReadLine(); 
            
        }
        private static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine("Height: {0}",rectangle.Height);
            Console.WriteLine("Width: {0}",rectangle.Width);
            Console.WriteLine("Area: {0}", rectangle.CalculateArea());
            Console.WriteLine("BorderColor: {0}",rectangle.BorderColor);
        }
    }
}
