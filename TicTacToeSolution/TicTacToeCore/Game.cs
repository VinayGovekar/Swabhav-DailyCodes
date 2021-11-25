using System;
using System.Collections.Generic;


namespace TicTacToeCore
{
    public class Game
    {
        private Player[] _players = new Player[2];
        private Board _board;
        private ResultAnalyzer _result;
        private ResultType _status;
        private Player _currentPlayer;
        public Game(Player[] players,Board board, ResultAnalyzer result)
        {
            _players = players;
            _currentPlayer = _players[0];
            _board = board;
            _result = result;
            _status = ResultType.NORESULT;
        }
        public void Play(int location)
        {
            _board.MarkCellAtLocation(location, _currentPlayer.Mark);
            _status=_result.Analyze();
            if(_status!=ResultType.WIN) SwitchPlayer(); 
        }
        public ResultType GetStatus()
        {
            return _status;
        }
        private void SwitchPlayer()
        {
            if (_currentPlayer == _players[0]) _currentPlayer = _players[1];
            else _currentPlayer = _players[0];
        }
        public Player CurrentPlayer { get { return _currentPlayer; } }
    }
}
