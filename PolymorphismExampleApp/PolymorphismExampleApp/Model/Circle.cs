using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExampleApp.Model
{
    class Circle:Shape
    {
        private double _radius;
        public Circle()
        {
            _radius = 10;
        }
        public override double Area()
        {
            return 3.14 * _radius * _radius;
        }
    }
}
