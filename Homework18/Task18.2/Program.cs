using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Task18._2
{
    internal class Program
    {
        // Create a custom linked list using yield return.
        static void Main(string[] args)
        {
            var myList = new CustomLinkedList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            

        }
    }
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }


        public Node(T value)
        {
            Value = value;
            Next = null;

        }


    }
    class CustomLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        public CustomLinkedList()
        {
            head = null;
        }
        public void Add(T value)
        {
            var newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
               while (current.Next != null)
               {
                    current = current.Next;
               }
               current.Next = newNode;
            }
        }
        public bool Remove(T value)
        {
            if (head == null)
            {
                return false;
            }
            if (EqualityComparer<T>.Default.Equals(value, head.Value))
            {
                head = head.Next;
                return true;
            }
            var current = head;
            while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Value, value))
            {
                current = (current.Next).Next;
            }
            if(current.Next == null)
            {
                return false;
            }
            current.Next = current.Next.Next;
            return true;
            
        }
        public bool Contains(T value)
        {
            var current = head;
            while(current != null)
            {
                if(EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } 

    
    
}
