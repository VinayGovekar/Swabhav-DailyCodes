using System;
using System.Collections.Generic;

namespace TicTacToeApp
{
    public class GameManager
    {
        private Board _board;
        private int _player;
        private bool _gameStatus;
        private int _currentPlayer;
        private List<int> _enteredList=new List<int>();
        public GameManager(Board board)
        {
            _player = 2;
            _board = board;
            _gameStatus = true;
        }
        private void CheckPlayer()
        {
            if (_player % 2 == 0) _currentPlayer=1;
            else _currentPlayer=2;
        }
        
        public void GetInput(string input)
        {
            _enteredList.Add(Convert.ToInt32(input));
            if (_currentPlayer==1) _board.SetData(Convert.ToInt32(input), " X ");
            else _board.SetData(Convert.ToInt32(input), " O ");
            _player++;
        }
        public int CheckWin()
        {
            if (_board.CheckWin() == 1)
            {
                _gameStatus = false;
                return _currentPlayer;
            }
            else if (_board.CheckWin() == -1)
            {
                _gameStatus = false;
                return -1;
            }
            _gameStatus = true;
            return 0;
        }
        public void ShowBoard()
        {
            Console.WriteLine("\nBoard:");
            _board.Fill();
            CheckPlayer();
            
        }
        public void ClearBoard()
        {
            _board.Clear();
        }
        public bool GameStatus
        {
            get { return _gameStatus; }
        }
        public int CurrentPlayer { get { return _currentPlayer; } }
        public List<int> InputList { get { return _enteredList; } }
    }
}
