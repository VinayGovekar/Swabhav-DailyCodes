using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager(new Board());
            while (game.GameStatus)
            {
                
                game.ShowBoard();
                Console.WriteLine("\nPlayer {0} turn:",game.CurrentPlayer);
                game.GetInput(ValidatedInput(game));
                int checker = game.CheckWin();
                game.ClearBoard();
                if (checker == 1) Console.WriteLine("\nGame won by player 1");
                else if (checker == 2) Console.WriteLine("\nGame won by player 2");
                else Console.WriteLine("Game draw");
            }
            Console.WriteLine("\nFinal Board:");
            game.ShowBoard();
            Console.WriteLine("\nThank you for playing");
            Console.ReadKey();
        }

        private static string ValidatedInput(GameManager game)
        { 
            Console.WriteLine("\nEnter Input: ");

            string input = Console.ReadLine();
            while (game.InputList.Contains(Convert.ToInt32(input)))
            {
                Console.WriteLine("That cell is already filled!!! Please Enter again:");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
