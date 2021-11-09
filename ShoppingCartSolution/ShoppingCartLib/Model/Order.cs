using System;
using System.Collections.Generic;
namespace ShoppingCartLib.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();
       
        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
           
        }
        public void AddItems(LineItem lineItem)
        {
            bool lineItemPresent = false;
            if(_items.Count==0) _items.Add(lineItem);
            else
            {
                foreach(var item in _items)
                {
                    if (item.Prod.Equals(lineItem.Prod))
                    {
                        item.Quantity += lineItem.Quantity;
                        lineItemPresent = true;
                        break;
                    }
                }
                if (lineItemPresent == false) _items.Add(lineItem);
            }
        }
        public int ID { get { return _id; } }
        public DateTime Date { get { return _date; } }
        public List<LineItem> Items { get { return _items; } }
        public int ItemCount {
            get
            {
                if (_items == null) return 0;
                return _items.Count;
            }
        }
        public double TotalOrderPrice(){
            double price = 0;
            foreach(var item in _items)
            {
                price += item.TotalPrice;
            }
            return price;
        }
    }
}
