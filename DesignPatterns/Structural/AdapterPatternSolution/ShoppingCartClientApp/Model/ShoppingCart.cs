using System;
using System.Collections.Generic;


namespace ShoppingCartClientApp.Model
{
    public class ShoppingCart
    {
        private List<IItem> _items = new List<IItem>();
        public void AddItem(IItem item)
        {
            _items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
        }
        public List<IItem> Items { get { return _items; } }
    }
}
