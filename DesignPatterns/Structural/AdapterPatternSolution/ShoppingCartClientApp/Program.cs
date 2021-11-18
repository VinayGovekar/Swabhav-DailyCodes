using System;
using ShoppingCartClientApp.Model;
using System.Collections.Generic;
using FancyItemsExternalLib;

namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new HatToItemAdapter(new Hat("Hat", "Premium ribboned golden hat", 500)));
            PrintCart(shoppingCart);
            Console.ReadKey();
        }
        public static void PrintCart(ShoppingCart cart)
        {
            foreach(var item in cart.Items)
            {
                Console.WriteLine("Item Details:");
                Console.WriteLine("Name: \t{0}",item.ItemName());
                Console.WriteLine("Price: \t{0}",item.ItemPrice());
            }
        }
    }
}
