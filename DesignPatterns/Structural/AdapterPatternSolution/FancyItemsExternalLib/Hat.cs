using System;


namespace FancyItemsExternalLib
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        public Hat(string shortName, string longName,double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }

        private double HatGst()
        {
            return (_basePrice * 8) / 100;
        }

        public string ShortName { get { return _shortName; } }

        public string LongName { get { return _longName; } }
        public double Price
        {
            get
            {
                return _basePrice + HatGst();
            }
        }
    }
}
