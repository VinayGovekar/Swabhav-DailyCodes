using System;
using TicTacToeCore;

namespace TicTacToeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = { new Player("Player1", MarkType.X), new Player("Player2", MarkType.O) };
            Board board = new Board();
            var result = new ResultAnalyzer(board);
            var game = new Game(players, board, result);
            Console.WriteLine("Game started");
            int[] inputSeq = { 0, 4, 8, 6, 2, 1, 5 };
            int i = 0;
            while (game.GetStatus() == ResultType.NORESULT)
            {
                Console.WriteLine("\nMove {0}:",i);
                Console.WriteLine("{0} : {1}",game.CurrentPlayer.Name,game.CurrentPlayer.Mark);
                Console.WriteLine("Location : {0}",inputSeq[i]);
                game.Play(inputSeq[i]);
                i++;
            }
            DisplayResult(game);
            Console.ReadLine();

        }
        static void DisplayResult(Game game)
        {
            if (game.GetStatus() == ResultType.WIN) Console.WriteLine("\n Game won by: {0} ",game.CurrentPlayer.Name);
            else Console.WriteLine("\nGame Draw");
        }
    }
}
