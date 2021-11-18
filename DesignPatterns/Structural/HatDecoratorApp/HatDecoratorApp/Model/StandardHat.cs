using System;

namespace HatDecoratorApp.Model
{
    public class StandardHat:IHat
    {
        private string _name;
        private double _price;

        public StandardHat()
        {
            _name = "Standard Hat";
            _price = 100;
        }
        public double GetCost()
        {
            return _price;
        }

        public string GetDescription()
        {
            return "Standard Hat: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
