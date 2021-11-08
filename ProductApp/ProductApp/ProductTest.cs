using System;
using ProductApp.Model;

namespace ProductApp
{
    class ProductTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

            Console.WriteLine("\n\nTotal Number of Objects: {0}",Product.Occurances);
            Console.ReadLine();
        }
        private static void CaseStudy2()
        {
            Product p1 = new Product(101, "Head First Java", 500.0);
            Console.WriteLine(p1.InstanceCount);
            Product p2 = new Product(102, "Head First C#", 200.0,10);
            Console.WriteLine(p2.InstanceCount);
            Product p3 = new Product(103, "Head First Java", 300.0,0.5);
            Console.WriteLine(p3.InstanceCount);
        }
        private static void CaseStudy1()
        {
            Product p1 = new Product(101, "Head First Java", 500.0);
            PrintDetails(p1);
            Product p2 = new Product(102, "Head First C#", 500, 0.10);
            PrintDetails(p2);

        }
        private static void PrintDetails(Product product)
        {
            Console.WriteLine("\nID: {0}",product.Id);
            Console.WriteLine("Name: {0}",product.Name);
            Console.WriteLine("Og Price: {0}", product.Price);
            Console.WriteLine("Discount: {0} %",product.Discount);
            Console.WriteLine("Final Price: {0}", product.CalculateFinalPrice());
        }
    }
}
