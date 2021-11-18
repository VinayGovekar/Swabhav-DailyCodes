using System;
using HatDecoratorApp.Model;

namespace HatDecoratorApp.Model.Decorator
{
    public class RibbonedHat : IHat
    {
        private IHat _hat;
        private double _price;
        private string _name;
        public RibbonedHat(IHat hat)
        {
            _hat = hat;
            _price = 100;
            _name = "Ribboned ";
        }
        public double GetCost()
        {
            return _price + _hat.GetCost();
        }

        public string GetDescription()
        {
            return _hat.GetDescription()+"\nRibbon: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name + _hat.GetName();
        }
    }
}
