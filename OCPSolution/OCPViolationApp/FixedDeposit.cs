
namespace OCPViolationApp
{
    public class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;
        public FixedDeposit(string name, double amount, int duration,FestivalType festival)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _festival = festival;
        }
        public double SimpleInterest()
        {
            return (_amount * _duration * CalculateRate()) / 100;
        }
        public double CalculateRate()
        {
            if (_festival == FestivalType.NEWYEAR) return 9.0;
            else if (_festival == FestivalType.EID) return 8.5;
            else if (_festival == FestivalType.DIWALI) return 8.0;
            return 7;
        }
    }
}
