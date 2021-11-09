using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders = new List<Order>();
        public int ID
        {
            get { return _id; }
        }
        public string Name { get { return _name; } }
        public List<Order> Orders { get { return _orders; } }

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }
         public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public int OrderCount { get
            {
                return _orders.Count;
            } 
        }
        public double GetTotalPriceOfAllOrders()
        {
            double totalPrice = 0;
            foreach(var order in _orders)
            {
                totalPrice += order.TotalOrderPrice();
            }
            return totalPrice;
        }

    }
}
