using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheCafeteria(manager);
            AtTheWorkstation(manager);
           // AtTheCafeteria(robot);
            AtTheWorkstation(robot);
            Console.ReadKey();
        }
        public static void AtTheCafeteria(IEatable eater)
        {
            eater.StartEat();
            eater.StopEat();
        }
        public static void AtTheWorkstation(IWorkable worker)
        {
            worker.StartWork();
            worker.StopWork();
        }
    }
}
