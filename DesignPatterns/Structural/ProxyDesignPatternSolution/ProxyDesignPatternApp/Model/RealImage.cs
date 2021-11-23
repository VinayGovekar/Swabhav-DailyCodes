using System;


namespace ProxyDesignPatternApp.Model
{
    public class RealImage : IImage
    {
        private string _fileName;
        public RealImage(string fileName)
        {
            _fileName = fileName;
            Console.WriteLine("Loading: {0}",_fileName);
        }
        public void Display()
        {
            Console.WriteLine("Displaying: "+_fileName);
        }
    }
}
