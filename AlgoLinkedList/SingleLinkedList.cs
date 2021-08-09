using System;

namespace AlgoLinkedList
{
    public class SingleLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            Node<T> tmp = Head;

            Head = node;

            Head.Next = tmp;
            count++;

            if (count == 1)
            {
                Tail = Head;
            }

        }

        public void AddLast(T Value)
        {
            AddLast(new Node<T>(Value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
                Head = node;
            else
                Tail.Next = node;

            Tail = node;

            count++;
        }

        public void Remove() 
        {
            if (IsEmpty)
                throw  new InvalidOperationException();

            Head = Head.Next;
            if (count == 1)
                Tail.Next = null;

            count--;

        }
            private bool IsEmpty => count == 0;
       
    }
        
}

