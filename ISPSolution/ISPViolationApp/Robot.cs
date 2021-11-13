using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp
{
    public class Robot : IWorker
    {
        public void StartEat()
        {
            throw new Exception("Robot cant eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot started working");
        }

        public void StopEat()
        {
            throw new Exception("Robot cant eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stopped working");
        }
    }
}
