using System;


namespace FactoryMethodLib.Product
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
