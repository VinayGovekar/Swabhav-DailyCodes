using System;
using SimpleDotComGameApp.Model;

namespace SimpleDotComGameApp
{
    class SimpleDotComGame
    {
        static void Main(string[] args)
        {
            string result="miss";
            string guess = "";
            int tryCount = 0;
            SimpleDotCom eachGuess = new SimpleDotCom();
            Console.WriteLine("Welcome to simple dotcom game!!!");
            Console.WriteLine("Abc.com is present in 3 cells Lets see how many turns you need to kill it!");
            eachGuess.SetLocationCells();
            do
            {
                tryCount += 1;
                Console.WriteLine("\nTry Count: {0}", tryCount);
                Console.WriteLine("Enter your guess:");
                guess = Console.ReadLine();
                result = eachGuess.CheckGuess(result,int.Parse(guess));
                Console.WriteLine(result);
            } while (result!="kill");
            Console.WriteLine("\nCongrats, Abc.com is killed in {0} try(s)", tryCount);
            Console.ReadLine();
        }
    }
}
