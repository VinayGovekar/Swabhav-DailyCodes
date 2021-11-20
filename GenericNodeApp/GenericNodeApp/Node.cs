using System;
using System.Collections.Generic;

namespace GenericNodeApp
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;
        public Node(){}
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Node<T> Next { get { return _next; }
            set { _next = value; }
        }
    }
}
