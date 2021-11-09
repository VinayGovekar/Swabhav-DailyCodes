using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;
namespace ShoppingCartLib.Test
{
    [TestClass]
    public class TestLineItem
    {
        [TestMethod]
        public void TestLineItemCreation()
        {
            LineItem lineItem = new LineItem(01,new Product(101, "Books", 250.50, 25f), 2);
            Assert.AreEqual<int>(2, lineItem.Quantity);
            Assert.AreEqual<Product>(new Product(101, "Books", 250.50, 25f), lineItem.Prod);
        }
        [TestMethod]
        public void TestLineItemPrice()
        {
            LineItem lineItem = new LineItem(01,new Product(101,"Books",250.50,25f),2);
            Assert.AreEqual<double>(375.75,lineItem.TotalPrice);
        }
    }
}
