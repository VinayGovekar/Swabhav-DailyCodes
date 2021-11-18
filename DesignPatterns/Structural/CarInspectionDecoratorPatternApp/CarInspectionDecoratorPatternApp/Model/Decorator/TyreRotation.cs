using CarInspectionDecoratorPatternApp.Model;
using System;

namespace CarInspectionDecoratorPatternApp.Model.Decorator
{
    public class TyreRotation : ICarService
    {
        private double _price;
        private ICarService _service;
        public TyreRotation(ICarService service)
        {
            _service = service;
            _price = 100;
        }
        public double GetCost()
        {
            return _price + _service.GetCost();
        }

        public string GetDetails()
        {
            return _service.GetDetails() + "\nTyre Rotation Charges: " + Convert.ToString(_price);
        }
    }
}
