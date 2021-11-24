using System;
using System.Collections.Generic;

namespace TicTacToeCore
{
    public class ResultAnalyzer
    {
        private Board _board;

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public ResultType Analyze()
        {
            if (CheckRow() == ResultType.WIN || CheckColumn() == ResultType.WIN || CheckDiagonal() == ResultType.WIN)
            {
                return ResultType.WIN;
            }
            else if (_board.CheckBoardFull()) return ResultType.DRAW;
            return ResultType.NORESULT;
        }
        private ResultType CheckRow()
        {
            if (CompareBoardCells(0,1,2)) return ResultType.WIN;

            else if (CompareBoardCells(3,4,5)) return ResultType.WIN;

            else if (CompareBoardCells(6,7,8)) return ResultType.WIN;

            return ResultType.NORESULT;
        }

        private ResultType CheckColumn()
        {
            if (CompareBoardCells(0,3,6)) return ResultType.WIN;

            else if (CompareBoardCells(1,4,7)) return ResultType.WIN;

            else if (CompareBoardCells(2,5,8)) return ResultType.WIN;

            return ResultType.NORESULT;
        }

        private ResultType CheckDiagonal()
        {
            if (CompareBoardCells(0,4,8)) return ResultType.WIN;

            else if (CompareBoardCells(2,4,6)) return ResultType.WIN;

            return ResultType.NORESULT;
        }
        private bool CompareBoardCells(int i,int j,int k)
        {
            if (_board.BoardCells[i].Mark == _board.BoardCells[j].Mark &&
                _board.BoardCells[j].Mark == _board.BoardCells[k].Mark) return true;
            return false;
        }
        
    }
}
