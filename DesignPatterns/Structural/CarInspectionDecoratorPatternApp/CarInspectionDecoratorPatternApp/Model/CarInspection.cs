using System;

namespace CarInspectionDecoratorPatternApp.Model
{
    public class CarInspection : ICarService
    {
        private double _price;
        public CarInspection()
        {
            _price = 500;
        }
        public double GetCost()
        {
            return _price;
        }

        public string GetDetails()
        {
            return "Basic Car Inspection: " + Convert.ToString(_price);
        }
    }
}
