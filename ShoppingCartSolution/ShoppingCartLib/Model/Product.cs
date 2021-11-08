
namespace ShoppingCartLib.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discount;

        public Product(int id, string name, double price, float discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discount = discount;
        }
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public override int GetHashCode()
        {
            return _id;
        }
        public override bool Equals(object obj)
        {
            Product matchProduct = (Product)obj;
            if (this.ID == matchProduct.ID && this.Name == matchProduct.Name) return true;
            return false;
        }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public float Discount { get { return _discount; } }
    }
}
