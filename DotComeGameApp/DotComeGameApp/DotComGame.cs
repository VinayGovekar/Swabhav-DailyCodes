using System;
using DotComeGameApp.Model;
namespace DotComeGameApp
{
    class DotComGame
    {
        static void Main(string[] args)
        {
            DotComGameManager ManagerObject = new DotComGameManager();
            string result = "miss";
            string guess="a0";
            string[] dotComNames = new string[3];
            int tryCount = 0;
            Console.WriteLine("Welcome to 'Sink the Dot Com' game!!!\nEnter the names of your dot coms");
            for(int i = 0; i < 3; i++)
            {
                dotComNames[i] = Console.ReadLine();
            }
            ManagerObject.SetDotComNameAndLoc(dotComNames);
            Console.WriteLine("\nSetting up your dot coms at random locations in a 7x7 grid(a0 to g6)");
           // ManagerObject.DisplayDotComLocations();
            do
            {
                tryCount++;
                Console.WriteLine("\nTurn Count: {0}", tryCount);
                Console.WriteLine("Enter your Guess:");
                guess = Console.ReadLine();
                result = ManagerObject.UserGuess(guess);
                Console.WriteLine(result);
            } while (result!= "All Ded");
            Console.WriteLine("\nCongrats you have sinked all the dot coms in {0} tries", tryCount);
            Console.ReadLine();
            
        }
    }
}
