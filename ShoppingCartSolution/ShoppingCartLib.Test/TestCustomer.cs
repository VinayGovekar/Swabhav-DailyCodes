using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartLib.Test
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void TestCustomerOrderCount()
        {
            Customer customer = new Customer(101, "Vinay");
            Assert.AreEqual<int>(0, customer.OrderCount);
            Order order1 = new Order(101, new DateTime(2021, 11, 09));
            order1.AddItems(new LineItem(101, new Product(101, "Books", 250, 0), 2));
            order1.AddItems(new LineItem(102, new Product(102, "Laptop", 30000, 0), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(103, new Product(103, "Milk", 25, 0), 2));
            order2.AddItems(new LineItem(102, new Product(104, "Cookies", 30, 0), 1));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            Assert.AreEqual<int>(2, customer.OrderCount);
        }
        [TestMethod]
        public void TestCustomerOrder()
        {
            Customer customer = new Customer(101, "Vinay");
            Order order1 = new Order(101, new DateTime(2021, 11, 09));
            order1.AddItems(new LineItem(101, new Product(101, "Books", 250, 0), 2));
            order1.AddItems(new LineItem(102, new Product(102, "Laptop", 30000, 0), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(103, new Product(103, "Milk", 25, 0), 2));
            order2.AddItems(new LineItem(102, new Product(102, "Cookies", 30, 0), 1));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            Assert.AreEqual<int>(102, customer.Orders[1].ID);
        }
    }
}
