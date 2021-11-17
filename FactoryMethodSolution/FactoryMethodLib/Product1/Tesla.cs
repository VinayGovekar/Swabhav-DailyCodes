using System;


namespace SimpleFactoryLib.Product
{
    class Tesla : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is stopping");
        }
    }
}
