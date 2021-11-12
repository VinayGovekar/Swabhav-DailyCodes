using System;
using LSPViolationApp.Model;
namespace LSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(10,20));
            Console.WriteLine("\nSquare:");
            ShouldNotChangeWidthIfHeightIsModified(new Square(5));
            Console.ReadKey();
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height += 10;
            var after = rectangle.Width;
            Console.WriteLine(before==after);
            Console.WriteLine(before);
            Console.WriteLine(after);
        }
    }
}
