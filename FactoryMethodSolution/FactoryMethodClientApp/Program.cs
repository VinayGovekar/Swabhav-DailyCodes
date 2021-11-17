using FactoryMethodLib.Factory;
using System;
namespace FactoryMethodClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = TeslaFactory.GetInstance();
            var auto = factory.Make();
            auto.Start();
            auto.Stop();
            Console.ReadKey();
        }
    }
}
