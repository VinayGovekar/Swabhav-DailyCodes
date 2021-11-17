using System;
using SimpleFactoryLib.Factory;

namespace SimpleFactoryClientApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var factory = AutomobileFactory.GetInstance();
            var automobile = factory.Make(AutoType.TESLA);
            automobile.Start();
            automobile.Stop();
            Console.WriteLine(factory.GetHashCode());

            var factory2 = AutomobileFactory.GetInstance();
            var automobile2 = factory2.Make(AutoType.AUDI);
            automobile2.Start();
            automobile2.Stop();

            Console.WriteLine(factory2.GetHashCode());
            
            Console.ReadKey();
        }
    }
}
