
namespace ShoppingCartLib.Model
{
    public class LineItem
    {
        private int _quantity;
        private double _totalPrice;
        private Product _product;
        public LineItem(Product product,int quantity) {
            _product = product;
            _quantity = quantity;
            _totalPrice = CalculateTotalPrice(product);
        }
        public double CalculateTotalPrice(Product product)
        {
            double singlePrice = product.Price - ((product.Price * product.Discount) / 100);
            return _quantity * singlePrice;
        }

        public Product Prod { get { return _product; } }
        public int Quantity { get { return _quantity; } }
        public double TotalPrice { get { return _totalPrice; } }
    }
}
