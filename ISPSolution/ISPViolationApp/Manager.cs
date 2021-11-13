using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp
{
    public class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager started eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager started working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stopped eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager stopped working");
        }
    }
}
