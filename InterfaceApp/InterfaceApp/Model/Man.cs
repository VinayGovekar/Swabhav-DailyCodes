using System;

namespace InterfaceApp.Model
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("Man says Goodbye");
        }

        public void Wish()
        {
            Console.WriteLine("Man wishes");
        }
    }
}
