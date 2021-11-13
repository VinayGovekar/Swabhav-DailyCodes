using System;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheCafeteria(manager);
            AtTheWorkstation(manager);
            //AtTheCafeteria(robot);
            AtTheWorkstation(robot);
            Console.ReadKey();
        }
        public static void AtTheCafeteria(IWorker worker)
        {
            worker.StartEat();
            worker.StopWork();
        }
        public static void AtTheWorkstation(IWorker worker)
        {
            worker.StartWork();
            worker.StopWork();
        }
    }
}
