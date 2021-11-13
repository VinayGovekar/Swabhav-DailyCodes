using System;
using RestraurantFacadeApp.Model;
namespace RestraurantFacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USER ORDERS FOR PIZZA:\n");
            var facadeForClient = new RestraurantFacade(new PizzaProvider(),new BreadProvider());
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\nUSER ORDERS FOR BREAD");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheeseGarlicBread();
            Console.ReadLine();
        }
    }
}
