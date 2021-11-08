using System;
using System.Collections.Generic;
using RicksInventoryApp.Model;
using RicksInventoryApp.Model.Enums;

namespace RicksInventoryApp
{
    class RicksUser
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            AddItems(inventory);
            SearchGuitar(new Guitar(Builder.FENDER, "Fender Stratocaster", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12), inventory);
            Console.ReadLine();
        }
        public static void AddItems(Inventory inventory)
        {
            inventory.AddInstrument(new Guitar("A101",1499.0,Builder.FENDER, "Fender Stratocaster", GType.ELECTRIC,Wood.ALDER,Wood.ALDER,12));
            inventory.AddInstrument(new Guitar("A102",1099.0,Builder.COLLINGS, "Superstrat", GType.ACOUSTIC,Wood.INDIAN_ROSEWOOD,Wood.INDIAN_ROSEWOOD,6));
            inventory.AddInstrument(new Guitar("A103", 1099.0, Builder.FENDER, "Fender Stratocaster", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12));
            inventory.AddInstrument(new Guitar("A104", 1799.0, Builder.FENDER, "Fender Stratocaster", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12));
            inventory.AddInstrument(new Guitar("A105", 1199.0, Builder.GIBSON, "Gibson Les Paul", GType.ACOUSTIC, Wood.MAHOGANY, Wood.MAPLE, 6));
        }
        public static void SearchGuitar(Instrument searchItem,Inventory inventory)
        {
            List<Instrument> itemList = inventory.SearchItem(searchItem);
            if (itemList.Count==0) Console.WriteLine("\nSorry no item found which matched your description");
            else
            {
                Console.WriteLine("\nFound items which matched your description");
                foreach(Guitar item in itemList)
                {
                    Console.WriteLine("\nWe have {0} {1}-strings {2} guitar:\n\t{3} back and sides\n\t{4} top\nYou can have it for Rs.{5}"
                        ,item.Model,item.NumberOfStrings,item.GuitarType,item.BackWood,item.TopWood,item.Price);
                }
            }
        }
    }
}
