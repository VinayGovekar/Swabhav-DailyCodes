

namespace TicTacToeCore
{
    public class Player
    {
        private string _name;
        private MarkType _mark;
        public Player(string name, MarkType mark)
        {
            _name = name;
            _mark = mark;
        }
        public string Name { get { return _name; } }
        public MarkType Mark { get { return _mark; } }
    }
}
