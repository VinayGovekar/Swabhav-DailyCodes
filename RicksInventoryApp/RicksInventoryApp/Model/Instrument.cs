using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksInventoryApp.Model
{
    public class Instrument
    {
        protected string _serialNumber;
        protected double _price;

        public string SerialNumber
        {
            get { return _serialNumber; }
        }
        public double Price
        {
            get { return _price; }
        }
    }
}
