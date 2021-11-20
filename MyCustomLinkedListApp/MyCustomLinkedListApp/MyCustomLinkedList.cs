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

        public void Add(Node<T> node)
        {
            if (_startNode == null) _startNode =node;
            else if (_startNode == _lastNode) _startNode.Next =node;
            else _lastNode.Next = node;
            _lastNode = node;
        }
        public void Remove(Node<T> node)
        {
            Node<T> testNode = _startNode;
            var nextNode = _startNode.Next;
            while (testNode!=null)
            {
                if (node == testNode && node == _startNode) {
                    _startNode = _startNode.Next;
                    break;
                }
                else if (nextNode == _lastNode)
                {
                    _lastNode = testNode;
                    break;
                }
                else if (nextNode == node)
                {
                    testNode.Next = nextNode.Next;
                    break;
                }
                testNode = testNode.Next;
            }
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
