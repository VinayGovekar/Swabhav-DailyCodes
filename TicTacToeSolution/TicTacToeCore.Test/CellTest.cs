using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;
using System;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void TestCellInitiallyEmpty()
        {
            Cell cell = new Cell();
            Assert.AreEqual<bool>(true, cell.IsEmpty());
        }

        [TestMethod]
        public void TestCellGettingMarked()
        {
            Cell cell = new Cell();
            cell.MarkCell(MarkType.X);
            Assert.AreEqual(MarkType.X, cell.Mark);
        }

        [TestMethod]
        public void TestCellGettingMarkedTwice()
        {
            Cell cell = new Cell();
            cell.MarkCell(MarkType.X);
            try
            {
                cell.MarkCell(MarkType.O);
                Assert.Fail();
            }
            catch (Exception)
            {
              
            }
        }
    }
}
