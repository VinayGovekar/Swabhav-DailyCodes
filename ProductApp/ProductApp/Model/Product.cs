using System;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discount;
        private static int _instanceCount;
        static Product(){
            _instanceCount = 0;
            Console.WriteLine("Static Constructor");
        }
        public Product(int id, string name, double price):this(id,name,price,2.00)
        {
            Console.WriteLine("Constructor 1");
        }
        public Product(int id,string name,double price, double discount)
        {
            Console.WriteLine("Constructor 2");
            _instanceCount += 1;
            _id = id;
            _name = name;
            _price = price;
            _discount = discount;
        }
        
        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
         
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
        }
        public static int Occurances
        {
            get
            {
                return _instanceCount;
            }
        }
        public double CalculateFinalPrice()
        {
            return (_price - ((_price * _discount) / 100));
        }

    }
}
