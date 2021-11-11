using System;

namespace OCPViolationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fixedDeposit = new FixedDeposit("Vinay",100000,5,FestivalType.DIWALI);
            Console.WriteLine("Simple Interest : Rs. {0}",fixedDeposit.SimpleInterest());
            Console.ReadKey();
        }
    }
}
