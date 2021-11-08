using System;
using RectangleAbstractionApp.Model;

namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.height = -6;
            small.width = -10;
            Rectangle big = new Rectangle();
            big.height = 80;
            big.width = 120;
            Rectangle temp = small;

            temp.width += 19;
            Console.WriteLine("Temp Width : {0}",temp.width);
            Console.WriteLine("Small Rectangle-> Width :{0} Height: {1} Area: {2}",small.width,small.height,small.CalculateArea());
            Console.WriteLine("\nBig Rectangle-> Width :{0} Height: {1} Area: {2}", big.width,big.height,big.CalculateArea());
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());
            Console.ReadLine();
        }
    }
}
