using System;

namespace RestraurantFacadeApp.Model
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza");
        }
        public void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Toppings");
        }
    }
}
