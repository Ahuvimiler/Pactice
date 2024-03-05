using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רשימה_מקושרת_חד_כוונית
{
    internal class List<T>
    {
        public Node<T> head;
        public void PushFrount(T value)
        {
            Node<T> n = new Node<T>(value, head);
            head = n;
        }
        public T TopFront()
        {
            //if (head != null) 
            return head.Value;
            //return -1;
        }
        public void PopFront()
        {
            if (head != null)
            {
                head = head.next;

            }
        }
        public void PushBack(T value)
        {
            Node<T> head1 = head;
            while (head1.next != null)
            {
                head1 = head1.next;
            }
            Node<T> n1 = new Node<T>(value);
            head1.next = n1;

        }
        public T TopBack()
        {
            Node<T> head2 = head;
            while (head2.next != null)
            {
                head2 = head2.next;
            }
            return head2.Value;
        }
        public void PopBack()
        {
            if (head != null)
            {
                Node<T> head3 = head;
                while (head3.next.next != null)
                {
                    head3 = head3.next;
                }
                head3.next = null;
            }
        }
        public Node<T> Find(T value)
        {
            Node<T> head4 = head;
            if (head4 != null)
            {
                while (head4.Value != value && head4 != null)
                {
                    head4 = head4.next;
                }
                if (head4 == null)
                {
                    return null;
                }
                return head4;
            }
            return null;
        }

        public void Erase(T value)
        {
            Node<T> head4 = head;
            if (head4 != null)
            {
                if (head4.Value == value)
                    head = head.next;
                while (head4.next.Value != value && head4.next != null)
                {
                    head4 = head4.next;
                }
                if(head4.next != null)
                {
                    head4.next= head4.next.next;
                }
            }
            
        }
        public bool Empty()
        {
            if(head== null) return true;
            return false;
        }
        public void AddBefore(Node<T>node,T value)
        {
           Node<T> head6 = head;
            if (head == node)
            {
                Node<T> node6 = new Node<T>(value, head);
                head=node6;
            }
            else {
                while (head6.next != node && head6.next != null)
                {
                    head6 = head6.next;
                }
                if (head6.next != null)
                {
                    Node<T> node6 = new Node<T>(value, head6.next);
                    head6.next = node6;
                }
            }
        }
        public void AddAfter(Node<T> node, T value)
        {
            if (head != null)
            {
                Node<T> node6 = new Node<T>(value, node.next);
                node.next = node6;
            }

        }
        public Node<T> ShirSur(List<T> L1, List<T> L2)
        {
            Node<T> Head1 = L1.head;
            while (Head1.next != null)
            {
                Head1 = Head1.next;
            }
            Head1.next = L2.head;
            return L1.head;
        }

        public int Length()
        {
            int count = 0;
            Node<T> head2 = head;
            while (head2 != null)
            {
                count++;    
                head2 = head2.next; 
            }
            return count;
        }
    }

}

