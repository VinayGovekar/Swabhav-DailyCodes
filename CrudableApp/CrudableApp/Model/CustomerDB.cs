using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    abstract class CustomerDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer is adding");
        }

        public void Read()
        {
            Console.WriteLine("Customer is Reading");
        }

        public abstract void Delete();
        public abstract void Update();
    }
}
