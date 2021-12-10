using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> locations = new string[] { "Mumbai", "Chennai", "Banglore", "Delhi", "Kolkata" };

            IEnumerable<string> locationsWithA = locations.Where(l => l.Contains("a"));

            IEnumerable<string> top3InAscending = locations.OrderBy(n=>n)
                                                           .Take(2);

            //foreach (var loc in top3InAscending) Console.WriteLine(loc);
            top3InAscending.ToList<string>().ForEach(Console.WriteLine);

            Console.ReadLine();

        }
    }
}
