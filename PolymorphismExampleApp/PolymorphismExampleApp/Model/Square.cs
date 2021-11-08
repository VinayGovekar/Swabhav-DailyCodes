using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExampleApp.Model
{
    class Square:Shape
    {
        private double _side;
        public Square()
        {
            _side = 5;
        }
        public override double Area()
        {
            return _side * _side;
        }
    }
}
