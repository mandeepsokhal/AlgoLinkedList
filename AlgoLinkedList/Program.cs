﻿using System;

namespace AlgoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 6 };
            first.Next = second;

            Node third = new Node() { Value = 3 };
            second.Next = third;
            PrintOutSingleLinkedList(first);
            Console.Read();
        }

        private static void PrintOutSingleLinkedList(Node node)
        {
            while(node!= null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
