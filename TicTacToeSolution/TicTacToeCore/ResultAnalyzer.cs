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
            if (_board.BoardCells[0].Mark == _board.BoardCells[1].Mark &&
                _board.BoardCells[1].Mark == _board.BoardCells[2].Mark) return ResultType.WIN;

            else if (_board.BoardCells[3].Mark == _board.BoardCells[4].Mark &&
                _board.BoardCells[4].Mark == _board.BoardCells[5].Mark) return ResultType.WIN;

            else if (_board.BoardCells[6].Mark == _board.BoardCells[7].Mark &&
                _board.BoardCells[7].Mark == _board.BoardCells[8].Mark) return ResultType.WIN;

            return ResultType.NORESULT;
        }

        private ResultType CheckColumn()
        {
            if (_board.BoardCells[0].Mark == _board.BoardCells[3].Mark &&
                _board.BoardCells[3].Mark == _board.BoardCells[6].Mark) return ResultType.WIN;

            else if (_board.BoardCells[1].Mark == _board.BoardCells[4].Mark &&
                _board.BoardCells[4].Mark == _board.BoardCells[7].Mark) return ResultType.WIN;

            else if (_board.BoardCells[2].Mark == _board.BoardCells[5].Mark &&
                _board.BoardCells[5].Mark == _board.BoardCells[8].Mark) return ResultType.WIN;

            return ResultType.NORESULT;
        }

        private ResultType CheckDiagonal()
        {
            if (_board.BoardCells[0].Mark == _board.BoardCells[4].Mark &&
                _board.BoardCells[4].Mark == _board.BoardCells[8].Mark) return ResultType.WIN;

            else if (_board.BoardCells[2].Mark == _board.BoardCells[4].Mark &&
                _board.BoardCells[4].Mark == _board.BoardCells[6].Mark) return ResultType.WIN;

            return ResultType.NORESULT;
        }
        
    }
}
