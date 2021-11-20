using System;
using System.Collections.Generic;

namespace TicTacToeApp
{
    public class Board
    {
        private string[] _board= {"   ", "   ","   ","   ","   ","   ","   ","   ","   "};
        public void Fill()
        {
            Console.WriteLine("\n{0}|{1}|{2}",_board[0],_board[1],_board[2]);
            Console.WriteLine("-----------");
            Console.WriteLine("{0}|{1}|{2}", _board[3], _board[4], _board[5]);
            Console.WriteLine("-----------");
            Console.WriteLine("{0}|{1}|{2}", _board[6], _board[7], _board[8]);
        }
        public void SetData(int data,string player)
        {
            _board[data] = player;
        }
        public void Clear()
        {
            Console.Clear();
        }

        public int CheckWin()
        {
            bool gameStatus=false;
            foreach (var cell in _board)
            {
                if (cell == "   ") gameStatus = true;
            }
            if (_board[0] == _board[1] && _board[1] == _board[2] && _board[0]!="   ") return 1;
            else if (_board[3] == _board[4] && _board[4] == _board[5] && _board[3] != "   ") return 1;
            else if (_board[6] == _board[7] && _board[7] == _board[8] && _board[6] != "   ") return 1;

            else if (_board[0] == _board[3] && _board[3] == _board[6] && _board[0] != "   ") return 1;
            else if (_board[1] == _board[4] && _board[4] == _board[7] && _board[1] != "   ") return 1;
            else if (_board[2] == _board[5] && _board[5] == _board[8] && _board[2] != "   ") return 1;

            else if (_board[0] == _board[4] && _board[4] == _board[8] && _board[0] != "   ") return 1;
            else if (_board[2] == _board[4] && _board[4] == _board[6] && _board[2] != "   ") return 1;
            else if (gameStatus == false) return -1;
            else return 0; 
        }
    }
}
