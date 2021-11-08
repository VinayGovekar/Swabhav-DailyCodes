using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _name;
        private double _price;
        private int _quantity;

        public LineItem(string name,double price,int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }

        public double TotalPrice()
        {
            return _price * _quantity;
        }

    }
}
