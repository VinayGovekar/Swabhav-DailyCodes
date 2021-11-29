using System;

namespace SimpleDelegateAppV2
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = (n) =>
            {
                Console.WriteLine("Inside Lambda 1");
                Console.WriteLine("Howdy says {0}", n);
            };
            f1("Vinay");

            f1 = (n) => Console.WriteLine("Ola says {0}",n);
            f1("Swabhav");

            Console.ReadKey();
        }
    }
}
