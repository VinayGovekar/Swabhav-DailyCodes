using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product is getting added");
        }

        public void Delete()
        {
            Console.WriteLine("Product is getting deleted");
        }

        public void Read()
        {
            Console.WriteLine("Product is getting read");
        }

        public void Update()
        {
            Console.WriteLine("Product is getting updated");
        }
    }
}
