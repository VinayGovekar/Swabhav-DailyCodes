using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void TestRowWin()
        {
            var board = new Board();
            board.MarkCellAtLocation(0,MarkType.X);
            board.MarkCellAtLocation(1, MarkType.X);
            board.MarkCellAtLocation(2, MarkType.X);
            /* X X X */
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.WIN, result.Analyze());
        }
        [TestMethod]
        public void TestNoResultFirst()
        {
            var board = new Board();
            board.MarkCellAtLocation(0, MarkType.X);
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.NORESULT, result.Analyze());
        }
        [TestMethod]
        public void TestColumnWin()
        {
            var board = new Board();
            board.MarkCellAtLocation(0, MarkType.X);
            board.MarkCellAtLocation(3, MarkType.X);
            board.MarkCellAtLocation(6, MarkType.X);
            /* X
             * X
             * X */
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.WIN, result.Analyze());
        }
        [TestMethod]
        public void TestDiagonalWin()
        {
            var board = new Board();
            board.MarkCellAtLocation(2, MarkType.X);
            board.MarkCellAtLocation(4, MarkType.X);
            board.MarkCellAtLocation(6, MarkType.X);
            /*X
             *  X
             *    X */
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.WIN, result.Analyze());
        }
        [TestMethod]
        public void TestDraw()
        {
            var board = new Board();
            board.MarkCellAtLocation(0, MarkType.X);
            board.MarkCellAtLocation(3, MarkType.X);
            board.MarkCellAtLocation(6, MarkType.O);
            board.MarkCellAtLocation(1, MarkType.O);
            board.MarkCellAtLocation(4, MarkType.O);
            board.MarkCellAtLocation(7, MarkType.X);
            board.MarkCellAtLocation(2, MarkType.X);
            board.MarkCellAtLocation(5, MarkType.O);
            board.MarkCellAtLocation(8, MarkType.X);
            /* X O X
             * X O O
             * O X X */
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.DRAW, result.Analyze());
        }

        [TestMethod]
        public void TestNoResult()
        {
            var board = new Board();
            board.MarkCellAtLocation(0, MarkType.X);
            board.MarkCellAtLocation(3, MarkType.X);
            board.MarkCellAtLocation(6, MarkType.O);
            board.MarkCellAtLocation(1, MarkType.O);
            board.MarkCellAtLocation(4, MarkType.O);
            board.MarkCellAtLocation(7, MarkType.X);
            board.MarkCellAtLocation(2, MarkType.X);
            board.MarkCellAtLocation(5, MarkType.O);
            /* X O X
             * X O O
             * O X   */
            ResultAnalyzer result = new ResultAnalyzer(board);
            Assert.AreEqual(ResultType.NORESULT, result.Analyze());
        }
    }
}
