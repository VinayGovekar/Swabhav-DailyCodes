using System;

namespace SimpleFactoryLib.Product
{
    class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi is stopping");
        }
    }
}
