using System;
using System.Collections.Generic;


namespace GenericNodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> node1 = new Node<string>();
            node1.Data = "Mumbai";

            Node<string> node2 = new Node<string>();
            node2.Data = "Pune";

            Node<string> node3 = new Node<string>();
            node3.Data = "Delhi";

            node1.Next = node2;
            node2.Next = node3;
            PrintDetails(node1);
            PrintDetails(node2);

            Console.ReadKey();
        }
        public static void PrintDetails(Node<string> node)
        {
            var newNode = node;
            Console.WriteLine("\nNodes:");
            while (newNode!= null)
            {
                
                PrintNode(newNode);
                newNode = newNode.Next;
            }
        }
        private static void PrintNode(Node<string> node)
        {
            Console.WriteLine("Data: {0}",node.Data);
        }
    }
}
