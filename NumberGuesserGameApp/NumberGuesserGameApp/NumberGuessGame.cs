using System;

namespace NumberGuesserGameApp
{
    class NumberGuessGame
    {
        static void Main(string[] args)
        {
            Random randomNumObject = new Random();
            int choice = 1;
            int userGuessChoice;
            do {
                //First Loop to start the game again

                int randomNum = randomNumObject.Next(1, 100);
                Console.WriteLine("Random number generated!!! {0}",randomNum);
                int tryCount = 0;
                do {
                    //Second Loop so that user can guess again

                    Console.WriteLine("\nGuess the number:");
                    userGuessChoice = int.Parse(Console.ReadLine());
                    tryCount = tryCount + 1;
                    if (userGuessChoice > randomNum){
                        Console.WriteLine("Sorry, Too High");
                    }
                    else if (userGuessChoice < randomNum){
                        Console.WriteLine("Sorry, Too Low");
                    }
                    else {
                        Console.WriteLine("\nCongrats you guessed the correct number in {0} try(s)", tryCount);
                    }
                }
                while (userGuessChoice!=randomNum);
                Console.WriteLine("\n1. Play Again\n2. Exit\n\nEnter choice:");
                choice = int.Parse(Console.ReadLine());
                if (choice > 2)
                {
                    Console.WriteLine("\nInvalid Choice!!!");
                }
            }
            while (choice==1);
        }
    }
}
