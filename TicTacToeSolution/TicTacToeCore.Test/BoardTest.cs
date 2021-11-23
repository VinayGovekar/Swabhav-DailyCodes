using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TestBoardFull()
        {
            Board board = new Board();
            for (int i = 0; i < board.BoardCells.Length; i++) board.MarkCellAtLocation(i, MarkType.X);
            Assert.AreEqual<bool>(true, board.CheckBoardFull());
        }

        [TestMethod]
        public void TestBoardEmpty()
        {
            Board board = new Board();
            Assert.AreEqual<bool>(true, board.CheckBoardEmpty());
        }

        [TestMethod]
        public void TestMarkCell()
        {
            var board = new Board();
            int location = 0;
            board.MarkCellAtLocation(location, MarkType.X);
            Assert.AreEqual(MarkType.X, board.GetMark(location));
        }

        [TestMethod]
        public void TestMarkCellTwice()
        {
            var board = new Board();
            int location = 0;
            board.MarkCellAtLocation(location, MarkType.X);
            try
            {
                board.MarkCellAtLocation(location, MarkType.O);
                Assert.Fail();
            }
            catch (Exception) {  }
        }
    }
}
