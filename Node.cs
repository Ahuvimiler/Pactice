using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רשימה_מקושרת_חד_כוונית
{
    internal class Node<T>
    {
        public T Value;
        public Node<T> next;
        public Node()
        {
            next = null;
        }
        public Node(T value)
        {
            next = null;
            this.Value = value;
        }
        public Node(T value, Node<T> next)
        {
            this.next = next;
            this.Value = value;
        }
    }
}
