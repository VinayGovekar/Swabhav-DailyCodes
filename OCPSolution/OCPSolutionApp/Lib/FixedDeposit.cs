using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Lib
{
    public class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private IFestivalPolicy _festivalPolicy;
        public FixedDeposit(string name, double amount, int duration, IFestivalPolicy festival)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _festivalPolicy = festival;
        }
        public double SimpleInterest()
        {
            return _amount * _duration * _festivalPolicy.CalculateRate();
        }
    }
}
