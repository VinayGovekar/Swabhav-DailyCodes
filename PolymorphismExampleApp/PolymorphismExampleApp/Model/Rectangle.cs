using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExampleApp.Model
{
    class Rectangle:Shape
    {
        private double _length;
        private double _breadth;

        public Rectangle()
        {
            _length = 10.00;
            _breadth = 5.00;
        }
        public override double Area()
        {
            return _breadth * _length;
        }
    }
}
