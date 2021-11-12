
namespace LSPSolutionApp
{
    class Square : IPolygon
    {
        private int _side;
        public Square(int side)
        {
            _side = side;
        }
        public int Side { get { return _side; } set { _side = value; } }
        public int CalculateArea()
        {
            return _side * _side;
        }
    }
}
