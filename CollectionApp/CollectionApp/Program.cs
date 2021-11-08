using System;
using System.Collections;
using System.Collections.Generic;
using CollectionApp.Model;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            AddItem(basket);
            DisplayBasket(basket);
            
        }
        public static void AddItem(IList basket)
        {
            basket.Add(new LineItem("Earphones", 150, 2));
            basket.Add(new LineItem("Kids toys", 500, 3));
            basket.Add(new LineItem("Phone", 1000, 1));
            basket.Add(new LineItem("Books", 250, 4));
        }
        public static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            AddItem(basket);
            double totalCost = 0;
            foreach (LineItem item in basket) {
                Console.WriteLine("Item: {0}\t\tQuantity:{1}\t\tPrice:{2}", item.Name, item.Quantity,item.TotalPrice());
                totalCost += item.TotalPrice();
            }
            Console.WriteLine("\nTotal Cost: {0}",totalCost);
        }
        public static void DisplayBasket(ArrayList basket)
        {
            double totalCost = 0;
           foreach(object item in basket)
            {
                LineItem lineItem = (LineItem)item;
                totalCost += lineItem.TotalPrice();
                Console.WriteLine("Name:{0}\t\tPrice: {1}",lineItem.Name,lineItem.TotalPrice());
            }
            Console.WriteLine("\nTotal Cost: {0}",totalCost);
        }
    }
}
