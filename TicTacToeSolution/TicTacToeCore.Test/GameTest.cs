using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestPlayerSwitch()
        {
            Player[] players = { new Player("Player1", MarkType.X), new Player("Player2", MarkType.O) };
            Board board = new Board();
            var result = new ResultAnalyzer(board);
            var game = new Game(players, board, result);
            var currentPlayer = players[0];
            Assert.AreEqual<Player>(currentPlayer, game.CurrentPlayer);
            game.Play(0);
            currentPlayer = players[1];
            Assert.AreEqual<Player>(currentPlayer, game.CurrentPlayer);
        }
        [TestMethod]
        public void TestWinGameResult()
        {
            Player[] players = { new Player("Player1", MarkType.X), new Player("Player2", MarkType.O) };
            Board board = new Board();
            var result = new ResultAnalyzer(board);
            var game = new Game(players, board, result);
            int[] inputSeq = { 0, 4, 8, 6, 2, 1, 5 };
            int i = 0;
            while (game.GetStatus() == ResultType.NORESULT)
            {
                game.Play(inputSeq[i]);
                i++;
            }
            Assert.AreEqual(ResultType.WIN, game.GetStatus());
        }
        [TestMethod]
        public void TestDrawGameResult()
        {
            Player[] players = { new Player("Player1", MarkType.X), new Player("Player2", MarkType.O) };
            Board board = new Board();
            var result = new ResultAnalyzer(board);
            var game = new Game(players, board, result);
            int[] inputSeq = { 0, 1, 2, 4, 7, 3, 5, 8, 6 };

            int i = 0;
            while (game.GetStatus() == ResultType.NORESULT)
            {
                game.Play(inputSeq[i]);
                i++;
            }
            Assert.AreEqual(ResultType.DRAW, game.GetStatus());
        }
        [TestMethod]
        public void TestGameWinner()
        {
            Player[] players = { new Player("Player1", MarkType.X), new Player("Player2", MarkType.O) };
            Board board = new Board();
            var result = new ResultAnalyzer(board);
            var game = new Game(players, board, result);
            int[] inputSeq = { 0, 4, 8, 6, 2, 1, 5 };
            int i = 0;
            while (game.GetStatus() == ResultType.NORESULT)
            {
                game.Play(inputSeq[i]);
                i++;
            }
            Assert.AreEqual(players[0], game.CurrentPlayer);
        }
    }
}
