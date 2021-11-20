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
            
            //Creating nodes
            var node1 = new Node<int>();
            node1.Data = 101;
            var node2 = new Node<int>();
            node2.Data = 102;
            var node3 = new Node<int>();
            node3.Data = 103;
            
            //Adding Nodes
            myLL.Add(node1);
            myLL.Add(node2);
            myLL.Add(node3);

            //Displaying count and nodes
            myLL.Display();
            Console.WriteLine("\nCount: {0}\n", myLL.Count());
            
            //Removing node and displaying
            myLL.Remove(node2);
            myLL.Display();
            Console.WriteLine("\nCount: {0}",myLL.Count());
            Console.ReadKey();
        }
    }
}
