using System;


namespace SimpleFactoryLib.Product
{
    class BMW : IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW is starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW is stopping");
        }
    }
}
