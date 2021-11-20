using System;
using System.Collections.Generic;


namespace MyCustomLinkedListApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinkedList Created
            var myLL = new MyCustomLinkedList<int>();
     
            //Adding items to linkedlist
            myLL.Add(101);
            myLL.Add(102);
            myLL.Add(103);
            myLL.Add(104);
            myLL.Add(105);

            //Displaying count and items
            myLL.Display();
            Console.WriteLine("\nCount: {0}\n", myLL.Count());
            
            //Removing item and displaying
            myLL.Remove(103);
            myLL.Display();
            Console.WriteLine("\nCount: {0}",myLL.Count());
            
            Console.ReadKey();
        }
    }
}
