using System;


namespace ProxyDesignPatternApp.Model
{
    public class ProxyImage : IImage
    {
        private string _fileName;
        private RealImage _realImage;
        public ProxyImage(string name)
        {
            _fileName = name;
        }
        public void Display()
        {
            if (_realImage == null) _realImage = new RealImage(_fileName);
            _realImage.Display();
        }
    }
}
