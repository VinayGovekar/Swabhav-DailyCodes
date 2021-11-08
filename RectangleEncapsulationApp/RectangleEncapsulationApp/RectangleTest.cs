using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle smallRectangle = new Rectangle();
            // smallRectangle.setHeight(-10);
            // smallRectangle.setWidth(400);
            Console.WriteLine(smallRectangle.abc);
            Console.WriteLine("Height: {0} , Width: {1}", smallRectangle.GetHeight(), smallRectangle.GetWidth());

            smallRectangle.setHeight(2000);
            smallRectangle.setWidth(-40);
            Console.WriteLine("Height: {0} , Width: {1}", smallRectangle.GetHeight(), smallRectangle.GetWidth());

            Console.ReadLine();
        }
    }
}
