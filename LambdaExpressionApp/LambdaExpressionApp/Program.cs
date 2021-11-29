using System;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printHowdy = (n) => Console.WriteLine("Howdy says {0}",n);
            printHowdy("Vinay");

            Action<string, string> printFullName = (f,l) => Console.WriteLine("First Name: {0} , Last Name: {1}",f,l);
            printFullName("Vinay", "Govekar");

            Func<int, int, long> calcRectArea = (l, b) => l * b;
            Console.WriteLine("Area of Rect: {0}",calcRectArea(5,3));

            Predicate<string> isALongName = (n) => n.Length > 8;
            Console.WriteLine(isALongName("asfgasags"));

            string userName = "SwabhavTechLabs";
            Console.WriteLine("Is {0} a long name ? {1}",userName,isALongName(userName));

            Console.ReadKey();
        }
    }
}
