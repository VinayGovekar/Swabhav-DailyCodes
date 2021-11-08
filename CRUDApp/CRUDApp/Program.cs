using System;
using System.Collections;
using System.Collections.Generic;
using CRUDApp.Model;

namespace CRUDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCRUDy();
            DictionaryCRUD();
            HashSetCRUD();
            Console.ReadLine();
        }

        public static void ArrayCRUDy()
        {
            ArrayListCRUD arrayList = new ArrayListCRUD();
            Console.WriteLine("\nArrayList Values: ");
            DisplayItems((ArrayList)arrayList.ReturnData());
            arrayList.UpdateArrayList(0, 100);
            arrayList.DeleteArrayListElement(100);
        }

        public static void DictionaryCRUD()
        {
            DictionaryCRUD dictionary = new DictionaryCRUD();
            Console.WriteLine("\nDictionary Values: ");
            DisplayItems((Dictionary<int,int>)dictionary.ReturnData());
            dictionary.UpdateDictionary(10, 100);
            dictionary.DeleteValueInDictionary(100);
        }
        public static void HashSetCRUD()
        {
            HashSetCRUD hs = new HashSetCRUD();
            Console.WriteLine("\nHashSet Values:");
            DisplayItems((HashSet<int>)hs.ReturnData());
            hs.UpdateSet(100);
            hs.DeleteItemFromSet(100);
        }
        public static void DisplayItems(IEnumerable items)
        {
            foreach (object item in items) Console.WriteLine("Value: {0}",item);
        }
    }
}
