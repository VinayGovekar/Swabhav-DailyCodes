using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartLib.Test
{
    [TestClass]
    public class TestProduct
    {
        [TestMethod]
        public void TestProductCreation()
        {
            Product product = new Product(101, "Books", 250.50, 0.25f);
            Assert.AreEqual<int>(101, product.ID);
            Assert.AreEqual<string>("Books", product.Name);
            Assert.AreEqual<double>(250.50, product.Price);
            Assert.AreEqual<float>(0.25f, product.Discount);
        }
    }
}
