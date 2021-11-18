using System;
using FancyItemsExternalLib;

namespace ShoppingCartClientApp.Model
{
    public class HatToItemAdapter : IItem
    {
        private Hat _hat;
        public HatToItemAdapter(Hat hat)
        {
            _hat = hat;
        }
        public string ItemName()
        {
            return _hat.ShortName;
        }

        public double ItemPrice()
        {
             return _hat.Price;
        }
    }
}
