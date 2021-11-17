using FactoryMethodLib.Factory;
using System;
using System.Configuration;

namespace FactoryMethodClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            var factory = reflector.GetInstanceFromAppConfig();
            var auto = factory.Make();
            auto.Start();
            auto.Stop();
            Console.ReadKey();
        }
    }
}
