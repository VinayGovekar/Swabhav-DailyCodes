using System;
using ShoppingCartLib.Model;

namespace ConsoleShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "Vinay");

            Order order1 = new Order(101, new DateTime(2021, 11, 09));
            order1.AddItems(new LineItem(1, new Product(101, "Books", 250, 25), 2));
            order1.AddItems(new LineItem(2, new Product(102, "Laptop", 30000, 10), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(1, new Product(103, "Milk", 25, 0), 2));
            order2.AddItems(new LineItem(2, new Product(104, "Cookies", 30, 0), 1));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            PrintDetails(customer);
            Console.ReadKey();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine("{0}'s orders:",customer.Name);
            Console.WriteLine("\nNo of orders: {0}",customer.OrderCount);
            foreach(var order in customer.Orders)
            {
                Console.WriteLine("\nOrder id: {0}",order.ID);
                Console.WriteLine("Order Date: {0}",order.Date);
                Console.WriteLine("Order Details:");
                Console.WriteLine("No of items: {0}",order.ItemCount);
                foreach(var lineItem in order.Items)
                {
                    Console.WriteLine("\n\tLineItem id: {0}",lineItem.ID);
                    Console.WriteLine("\t\tProduct ID: {0}",lineItem.Prod.ID);
                    Console.WriteLine("\t\tProduct Name: {0}",lineItem.Prod.Name);
                    Console.WriteLine("\t\tOriginal Price: {0}",lineItem.Prod.Price);
                    Console.WriteLine("\t\tDiscount: {0}",lineItem.Prod.Discount);
                    Console.WriteLine("\t\tDiscounted Price: {0}",lineItem.Prod.GetDiscountedPrice());
                    Console.WriteLine("\tQuantity: {0}",lineItem.Quantity);
                    Console.WriteLine("\tTotal Price for LineItem: {0}",lineItem.TotalPrice);
                }
                Console.WriteLine("\nTotal Price for current order: {0}",order.TotalOrderPrice());
            }
            Console.WriteLine("\nTotal Amount for {0} is {1}",customer.Name,customer.GetTotalPriceOfAllOrders());
            
        }

    }
}
