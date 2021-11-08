using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private ColorType _borderColor;

        public Rectangle()
        {
            Console.WriteLine("\nRectangle Created!!!");
            _borderColor = ColorType.RED;
        }
        

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height= ValidateDimension(value);
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = ValidateDimension(value);
            }
        }
        public ColorType BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
            }
        }
        private int ValidateDimension(int dimension)
        {
            if (dimension > 100)
            {
                dimension = 100;
            }
            else if (dimension < 1)
            {
                dimension = 1;
            }
            return dimension;
        }
        public int CalculateArea()
        {
            return _height * _width;
        }
    }
}
