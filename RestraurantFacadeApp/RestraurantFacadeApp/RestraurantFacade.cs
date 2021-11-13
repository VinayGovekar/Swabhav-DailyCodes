using System;
using RestraurantFacadeApp.Model;
namespace RestraurantFacadeApp
{
    public class RestraurantFacade
    {
        private PizzaProvider _pizza;
        private BreadProvider _bread;
        public RestraurantFacade(PizzaProvider pizza,BreadProvider bread)
        {
            _pizza = pizza;
            _bread = bread;
        }
        public void GetNonVegPizza()
        {
            _pizza.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _pizza.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _bread.GetGarlicBread();
        }
        public void GetCheeseGarlicBread()
        {
            _bread.GetCheeseGarlicBread();
        }
    }
}
