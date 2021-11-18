using System;
using CarInspectionDecoratorPatternApp.Model;
using CarInspectionDecoratorPatternApp.Model.Decorator;

namespace CarInspectionDecoratorPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OilChange(new TyreRotation(new CarInspection()));
            Console.WriteLine(service.GetDetails());
            Console.WriteLine("Total Cost: {0}",service.GetCost());
            Console.ReadKey();
        }
    }
}
