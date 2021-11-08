using System.Collections.Generic;
namespace RicksInventoryApp.Model
{
    public class Inventory
    {
        private List<Instrument> _inventory = new List<Instrument>();
        public void AddInstrument(Instrument instrument)
        {
            _inventory.Add(instrument);
        }
        public Instrument GetItem(string serialNum)
        {
            foreach(Instrument item in _inventory) if (item.SerialNumber == serialNum) return item;
            return null;
        }
        public List<Instrument> SearchItem(Instrument searchItem)
        {
            List<Instrument> matchedItems = new List<Instrument>();
            foreach(Instrument item in _inventory)
            {
                if (item.Equals(searchItem)) matchedItems.Add(item);
            }
            return matchedItems;
        }
    }
}
