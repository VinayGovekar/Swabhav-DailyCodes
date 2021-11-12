
namespace LSPViolationApp.Model
{
    public class Square:Rectangle
    {   
        public Square(int side) : base(side, side) { }
        public override int Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Width 
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
