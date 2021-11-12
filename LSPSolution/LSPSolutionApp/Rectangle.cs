using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp
{
    class Rectangle : IPolygon
    {
        private int _height;
        private int _width;
        public  Rectangle(int height,int width)
        {
            _height = height;
            _width = width;
        }
        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }
        public int CalculateArea()
        {
            return _height * _width;
        }
    }
}
