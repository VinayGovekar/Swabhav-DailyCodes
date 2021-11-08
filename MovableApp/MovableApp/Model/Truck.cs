using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableApp.Model
{
    class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}
