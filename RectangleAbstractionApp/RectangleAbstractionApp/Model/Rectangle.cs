using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAbstractionApp.Model
{
    class Rectangle
    {
        public int width;
        public int height;

        public int CalculateArea()
        {
            return width*height ;
        }
    }
}
