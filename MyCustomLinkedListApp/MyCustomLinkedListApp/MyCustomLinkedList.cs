using System;
using System.Collections.Generic;

namespace MyCustomLinkedListApp
{
    public class MyCustomLinkedList<T>
    {
        private Node<T> _lastNode;
        private Node<T> _startNode;

        public MyCustomLinkedList()
        {
            _startNode = null;
            _lastNode = null;
        }

        public void Add(T data)
        {
            var newNode = new Node<T>();
            newNode.Data = data;
            if (_startNode == null) {
                _startNode = newNode; 
            }
            else _lastNode.Next = newNode;
            _lastNode = newNode;
        }
        public void Remove(T data)
        {
            Node<T> currentNode = _startNode;
            Node<T> prevNode =null;
            while (currentNode!=null)
            {
                if (data.Equals(_startNode.Data)) {
                    _startNode = _startNode.Next;
                    break;
                }
                else if (currentNode.Data.Equals(data))
                {
                    RemoveCurrentNode(currentNode, prevNode);
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        private void RemoveCurrentNode(Node<T> currentNode,Node<T> prevNode)
        {
            if (currentNode == _lastNode)
            {
                prevNode.Next = null;
                _lastNode = prevNode;
            }
            else prevNode.Next = currentNode.Next;
        }
        public int Count()
        {
            int count = 0;
            var testNode = _startNode;
            while (testNode != null)
            {
                count += 1;
                testNode = testNode.Next;
            }

            return count;
        }
        public void Display()
        {
            var testNode = _startNode;
            while (testNode != null)
            {
                Console.WriteLine(testNode.Data);
                testNode = testNode.Next;
            }
        }
    }
}
