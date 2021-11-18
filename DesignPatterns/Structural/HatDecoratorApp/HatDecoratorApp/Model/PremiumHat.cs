using System;

namespace HatDecoratorApp.Model
{
    public class PremiumHat : IHat
    {
        private string _name;
        private double _price;
        public PremiumHat()
        {
            _name = "Premium Hat";
            _price = 500;
        }
        public double GetCost()
        {
            return _price;
        }

        public string GetDescription()
        {
            return "Premium Hat: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
