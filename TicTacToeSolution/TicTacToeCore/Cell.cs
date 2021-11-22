using System;

namespace TicTacToeCore
{
    public class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
        
        public void MarkCell(MarkType mark)
        {
            if (!this.IsEmpty())
            {
                throw new Exception("Cell is already marked!");
            }
            _mark = mark;
        }
        public bool IsEmpty()
        {
            if (_mark == MarkType.EMPTY) return true;
            return false;
        }
        public MarkType Mark { get { return _mark; } }
    }
}
