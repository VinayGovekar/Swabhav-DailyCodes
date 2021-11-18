using System;
using HatDecoratorApp.Model;

namespace HatDecoratorApp.Model.Decorator
{
    public class GoldenHat:IHat
    {
        private IHat _hat;
        private double _price;
        private string _name;
        public GoldenHat(IHat hat)
        {
            _hat = hat;
            _price = 50;
            _name = "Golden ";
        }

        public double GetCost()
        {
            return _price + _hat.GetCost();
        }

        public string GetDescription()
        {
            return _hat.GetDescription() + "\nGolder Color: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name + _hat.GetName();
        }
    }
}
