using System;
using HatDecoratorApp.Model;
using HatDecoratorApp.Model.Decorator;
namespace HatDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hat = new RibbonedHat(new GoldenHat(new PremiumHat()));
            PrintHat(hat);
            var hat2 = new GoldenHat(new StandardHat());
            PrintHat(hat2);
            Console.ReadKey();
        }

        public static void PrintHat(IHat hat)
        {
            Console.WriteLine("\n\nHat Details:");
            Console.WriteLine("\nName: {0}", hat.GetName());
            Console.WriteLine("\nDescription:");
            Console.WriteLine(hat.GetDescription());
            Console.WriteLine("\nTotalCost: {0}",hat.GetCost());
        }
    }
}
