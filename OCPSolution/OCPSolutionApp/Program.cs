using System;
using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fixedDeposit1 = new FixedDeposit("Vinay", 50000, 5, new DiwaliFestivalPolicy());
            Console.WriteLine("\nSimple Interest: {0}",fixedDeposit1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
