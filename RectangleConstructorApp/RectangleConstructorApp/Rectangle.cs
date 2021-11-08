using System;

namespace RectangleConstructorApp
{
    class Rectangle
    {
        private int _width = 0;
        private int _height = 0;
        private string _color = "red";
        private string _borderColor = "blue";

        public Rectangle(int width, int height, string color){
            _width = ValidateDimensions(width);
            _height = ValidateDimensions(height);
            _color = ValidateColor(color);
        }
        public Rectangle(int width, int height, string color, string bordorColor)
        {
            _width = ValidateDimensions(width);
            _height = ValidateDimensions(height);
            _color = ValidateColor(color);
            _borderColor = ValidateColor(bordorColor);
        }
        private string ValidateColor(string color)
        {
            color = color.ToLower();
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            return "red";
        }
        private int ValidateDimensions(int dimension)
        {
            if (dimension > 100) {
                return 100;
            }
            else if (dimension < 1)
            {
                return 1;
            }
            else
            {
                return dimension;
            }
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }
        public string GetColor()
        {
            return _color;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

    }
}
