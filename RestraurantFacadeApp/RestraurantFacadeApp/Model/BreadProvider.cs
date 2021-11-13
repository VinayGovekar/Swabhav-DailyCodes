using System;

namespace RestraurantFacadeApp.Model
{
    public class BreadProvider : IBread
    {
        public void GetCheeseGarlicBread()
        {
            GetCheese();
            GetGarlicBread();
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese");
        }
    }
}
