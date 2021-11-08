using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order is getting added");
        }

        public void Delete()
        {
            Console.WriteLine("Order is getting deleted");
        }

        public void Read()
        {
            Console.WriteLine("Order is getting read");
        }

        public void Update()
        {
            Console.WriteLine("Order is getting updated");
        }
    }
}
