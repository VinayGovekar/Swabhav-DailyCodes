using System;
using System.Linq;
using System.Collections.Generic;
using ExtensionMethodApp.MyExtensionMethods;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "AurionPro";

            Console.WriteLine(name.Foo());

            IEnumerable<string> locations = new string[] { "Mumbai", "Banglore", "Chennai", "Delhi", "Kolkata" };
            //locations.Where();  Without linq IEnumerable does not contains where
            locations.Where(s=>s.Contains("a"));
            locations.forEac
            Console.ReadLine();
        }
    }
}
