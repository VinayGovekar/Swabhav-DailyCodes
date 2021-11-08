using System;
namespace PigGameApp
{
    class Program
    {
        static int targetScore = 20;
        public static int EachTurn(int currentScore,ref int scoreBank)
        {
            Random randomNumGenerator = new Random();
            int dieNumber;
            String userChoice;
            do
            {
                Console.WriteLine("\nCurrent Score: {0}", currentScore);
                Console.WriteLine("Roll or Hold?(r/h)");
                userChoice = Console.ReadLine();
                if (userChoice == "r")
                {
                    dieNumber = randomNumGenerator.Next(1, 6);
                    Console.WriteLine("Die: {0}",dieNumber);
                    if (dieNumber == 1)
                    {
                        Console.WriteLine("Sorry you rolled 1, your score for the current turn will be reseted");
                        currentScore = scoreBank;
                        return currentScore;
                    }
                    else
                    {
                        currentScore = currentScore + dieNumber;
                        if (currentScore >= targetScore)
                        {
                            return currentScore;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Holding for current turn and saving your score!");
                    scoreBank = currentScore;
                }
            }
            while (userChoice != "h");
            return currentScore;
        }
        static void Main(string[] args)
        {
            int turnCount=0;
            int currentScore=0;
            int scoreBank=0;
            Console.WriteLine("Welcome to the PIG game!!!");
            do {
                turnCount = turnCount + 1;
                Console.WriteLine("\n--------------");
                Console.WriteLine("Turn Count: {0}",turnCount);
                Console.WriteLine("--------------");
                currentScore = EachTurn(currentScore,ref scoreBank);
            }
            while (currentScore<targetScore);
            Console.WriteLine("\nCongrats you have completed the game in {0} turn(s)\nThanks for playing the game Sayonara!!", turnCount);
            Console.ReadLine();
        }
    }
}
