using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private float _radius = 1.0f;
        private string _borderColor = "red";
        private string _fillColor = "red";

        private string ValidateColor(string color)
        {
            color = color.ToLower();
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            return "red";
        }
        public void SetRadius(float radius)
        {
            const float UPPERBOUND=10.00f;
            const float LOWERBOUND = 1.0f;
            if (radius>UPPERBOUND) {
                radius = UPPERBOUND;            
            }
            else if (radius < LOWERBOUND)
            {
                radius = LOWERBOUND;
            }
            _radius = radius;
        }
        public void SetBorderColor(string borderColor)
        {
           _borderColor = ValidateColor(borderColor);
        }
        public void SetFillColor(string fillColor)
        {
            _fillColor = ValidateColor(fillColor);
        }
        
        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public string GetFillColor()
        {
            return _fillColor;
        }

        public float CalculateArea()
        {
            const float PIE = 3.14f;
            return PIE * (_radius * _radius);
        }
    }
}
