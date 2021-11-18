using System;
using CarInspectionDecoratorPatternApp.Model;

namespace CarInspectionDecoratorPatternApp.Model.Decorator
{
    public class OilChange : ICarService
    {
        private double _price;
        private ICarService _service;
        public OilChange(ICarService service)
        {
            _service = service;
            _price = 200;
        }
        public double GetCost()
        {
            return _price+ _service.GetCost();
        }

        public string GetDetails()
        {
            return _service.GetDetails() + "\nOil Change charges: " + Convert.ToString(_price);
        }
    }
}
